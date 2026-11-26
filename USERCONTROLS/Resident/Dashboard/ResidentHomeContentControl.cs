
using System;
using System.Data;
using System.Windows.Forms;
using Barangay_E_Service_System.DATA;
using Microsoft.Data.SqlClient;

namespace Barangay_E_Service_System.USERCONTROLS.Resident
{
    public partial class ResidentHomeContentControl : UserControl
    {
        private string residentID;
        public ResidentHomeContentControl()
        {
            InitializeComponent();
        }

        public ResidentHomeContentControl(string residentID) : this()
        {
   
            this.residentID = residentID;
            LoadResidentRequests(residentID);
        }

        private void LoadResidentRequests(string residentID)
        {
            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    string reservationTableName = FindEquipmentReservationTable(connection);
                    LoadRequestCounts(connection, residentID, reservationTableName);

                    DataTable requestRows = CreateRequestTable();
                    LoadCertificateRequests(connection, residentID, requestRows);
                    LoadComplaintRequests(connection, residentID, requestRows);

                    if (reservationTableName.Length > 0)
                    {
                        LoadEquipmentRequests(connection, residentID, requestRows, reservationTableName);
                    }

                    DisplayRecentRequests(requestRows);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load your dashboard requests: " + ex.Message, "Resident Dashboard");
            }
        }

        private void LoadRequestCounts(SqlConnection connection, string residentID, string reservationTableName)
        {
            string equipmentTable = "";

            if (reservationTableName.Length > 0)
            {
                equipmentTable = " + (SELECT COUNT(*) FROM dbo.[" + reservationTableName.Replace("]", "]]") + "] WHERE ResidentID = @ResidentID)";
            }

            string pendingEquipment = "";
            string approvedEquipment = "";

            if (reservationTableName.Length > 0)
            {
                string safeTableName = "dbo.[" + reservationTableName.Replace("]", "]]") + "]";
                pendingEquipment = " + (SELECT COUNT(*) FROM " + safeTableName + " WHERE ResidentID = @ResidentID AND Status = 'Pending')";
                approvedEquipment = " + (SELECT COUNT(*) FROM " + safeTableName + " WHERE ResidentID = @ResidentID AND Status = 'Approved')";
            }

            string query = "SELECT " +
                           "(SELECT COUNT(*) FROM dbo.CertificateRequests WHERE ResidentID = @ResidentID) + " +
                           "(SELECT COUNT(*) FROM dbo.Complaints WHERE ResidentID = @ResidentID)" + equipmentTable + " AS TotalCount, " +
                           "(SELECT COUNT(*) FROM dbo.CertificateRequests WHERE ResidentID = @ResidentID AND Status = 'Pending') + " +
                           "(SELECT COUNT(*) FROM dbo.Complaints WHERE ResidentID = @ResidentID AND Status = 'Pending')" + pendingEquipment + " AS PendingCount, " +
                           "(SELECT COUNT(*) FROM dbo.CertificateRequests WHERE ResidentID = @ResidentID AND Status = 'Approved') + " +
                           "(SELECT COUNT(*) FROM dbo.Complaints WHERE ResidentID = @ResidentID AND Status = 'Approved')" + approvedEquipment + " AS ApprovedCount";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ResidentID", residentID);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        lblTotalCount.Text = reader["TotalCount"].ToString();
                        lblPendingCount.Text = reader["PendingCount"].ToString();
                        lblApprovedCount.Text = reader["ApprovedCount"].ToString();
                    }
                }
            }
        }

        private DataTable CreateRequestTable()
        {
            DataTable requestTable = new DataTable();
            requestTable.Columns.Add("ReferenceID", typeof(string));
            requestTable.Columns.Add("RequestType", typeof(string));

            DataColumn requestedDateColumn = requestTable.Columns.Add("DateRequested", typeof(DateTime));
            requestedDateColumn.AllowDBNull = true;

            requestTable.Columns.Add("Status", typeof(string));

            return requestTable;
        }

        private void LoadCertificateRequests(SqlConnection connection, string residentID, DataTable requestTable)
        {
            string query = @"SELECT ReferenceID, CertificateType AS RequestType, DateRequested, Status
                             FROM dbo.CertificateRequests
                             WHERE ResidentID = @ResidentID
                             ORDER BY DateRequested DESC, RequestID DESC";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ResidentID", residentID);
                AddRowsToRequestTable(command, requestTable, "");
            }
        }

        private void LoadComplaintRequests(SqlConnection connection, string residentID, DataTable requestTable)
        {
            string query = @"SELECT ReferenceID, Category, DateSubmitted AS DateRequested, Status
                             FROM dbo.Complaints
                             WHERE ResidentID = @ResidentID
                             ORDER BY DateSubmitted DESC, ComplaintID DESC";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ResidentID", residentID);
                AddRowsToRequestTable(command, requestTable, "Complaint: ");
            }
        }

        private void LoadEquipmentRequests(SqlConnection connection, string residentID, DataTable requestTable, string tableName)
        {
            string requestDateColumn = FindEquipmentRequestDateColumn(connection, tableName);
            string safeTableName = "dbo.[" + tableName.Replace("]", "]]") + "]";
            string query;

            if (requestDateColumn.Length > 0)
            {
                string safeDateColumn = "[" + requestDateColumn.Replace("]", "]]") + "]";
                query = "SELECT ReferenceID, EventName, " + safeDateColumn + " AS DateRequested, Status FROM " + safeTableName + " WHERE ResidentID = @ResidentID ORDER BY " + safeDateColumn + " DESC";
            }
            else
            {
                query = "SELECT ReferenceID, EventName, CAST(NULL AS datetime2) AS DateRequested, Status FROM " + safeTableName + " WHERE ResidentID = @ResidentID";
            }

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ResidentID", residentID);
                AddRowsToRequestTable(command, requestTable, "Equipment: ");
            }
        }

        private string FindEquipmentReservationTable(SqlConnection connection)
        {
            string query = @"SELECT TOP (1) TABLE_NAME
                             FROM INFORMATION_SCHEMA.TABLES
                             WHERE TABLE_SCHEMA = 'dbo'
                               AND TABLE_NAME IN ('EquipmentReservation', 'EquipmentReservations')
                             ORDER BY CASE TABLE_NAME
                                 WHEN 'EquipmentReservation' THEN 0
                                 WHEN 'EquipmentReservations' THEN 1
                                 ELSE 2
                             END";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                object result = command.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                {
                    return "";
                }

                return (string)result;
            }
        }

        private string FindEquipmentRequestDateColumn(SqlConnection connection, string tableName)
        {
            string query = @"SELECT TOP (1) COLUMN_NAME
                             FROM INFORMATION_SCHEMA.COLUMNS
                             WHERE TABLE_SCHEMA = 'dbo'
                               AND TABLE_NAME = @TableName
                               AND COLUMN_NAME IN ('DateRequested', 'DateSubmitted', 'CreatedAt', 'CreatedDate', 'RequestDate', 'RequestedAt', 'SubmittedAt')
                               AND DATA_TYPE IN ('date', 'datetime', 'datetime2', 'smalldatetime', 'datetimeoffset')
                             ORDER BY CASE COLUMN_NAME
                                 WHEN 'DateRequested' THEN 0
                                 WHEN 'DateSubmitted' THEN 1
                                 WHEN 'CreatedAt' THEN 2
                                 WHEN 'CreatedDate' THEN 3
                                 WHEN 'RequestDate' THEN 4
                                 WHEN 'RequestedAt' THEN 5
                                 WHEN 'SubmittedAt' THEN 6
                                 ELSE 7
                             END";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@TableName", tableName);
                object result = command.ExecuteScalar();

                if (result == null || result == DBNull.Value)
                {
                    return "";
                }

                string columnName = (string)result;

                if (columnName == null)
                {
                    return "";
                }

                return columnName;
            }
        }

        private void AddRowsToRequestTable(SqlCommand command, DataTable requestTable, string requestTypePrefix)
        {
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string referenceID = GetReaderText(reader, 0);
                    string requestType = GetReaderText(reader, 1);
                    DateTime requestedDate = DateTime.MinValue;
                    bool hasRequestedDate = reader[2] != DBNull.Value;

                    if (hasRequestedDate)
                    {
                        requestedDate = Convert.ToDateTime(reader.GetValue(2));
                    }

                    string status = GetReaderText(reader, 3);

                    DataRow requestRow = requestTable.NewRow();
                    requestRow["ReferenceID"] = referenceID;
                    requestRow["RequestType"] = requestTypePrefix + requestType;
                    requestRow["DateRequested"] = hasRequestedDate ? (object)requestedDate : DBNull.Value;
                    requestRow["Status"] = status;

                    requestTable.Rows.Add(requestRow);
                }
            }
        }

        private string GetReaderText(SqlDataReader reader, int columnIndex)
        {
            object value = reader.GetValue(columnIndex);

            if (value == null || value == DBNull.Value)
            {
                return "";
            }

            return value.ToString();
        }
        private void DisplayRecentRequests(DataTable requestTable)
        {
            DataView sortedRequests = new DataView(requestTable);
            sortedRequests.Sort = "DateRequested DESC";
            dgvRecentRequests.DataSource = sortedRequests.ToTable();
        }


        private void dgvRecentRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dgvRecentRequests.Columns[e.ColumnIndex].Name != "btnView")
                return;

            string referenceID = dgvRecentRequests.Rows[e.RowIndex]
                .Cells["ReferenceID"].Value?.ToString();

            if (string.IsNullOrEmpty(referenceID))
                return;

            string query;

            if (referenceID.StartsWith("CRT-"))
            {
                query = @"
            SELECT ReferenceID, CertificateType, Purpose,
                   DateRequested, AdditionalRemarks, Status
            FROM dbo.CertificateRequests
            WHERE ReferenceID = @ReferenceID
            AND ResidentID = @ResidentID";
            }
            else if (referenceID.StartsWith("CMP-"))
            {
                query = @"
            SELECT ReferenceID, Category, IncidentLocation,
                   Description, IncidentDate, DateSubmitted, Status
            FROM dbo.Complaints
            WHERE ReferenceID = @ReferenceID
            AND ResidentID = @ResidentID";
            }
            else if (referenceID.StartsWith("RSV-"))
            {
                query = @"
            SELECT ER.ReferenceID, E.EquipmentName, ER.Quantity,
                   ER.EventName, ER.EventDate, ER.ReturnDate,
                   ER.Purpose, ER.DateRequested, ER.Status
            FROM dbo.EquipmentReservations ER
            INNER JOIN dbo.Equipment E ON ER.EquipmentID = E.EquipmentID
            WHERE ER.ReferenceID = @ReferenceID
            AND ER.ResidentID = @ResidentID";
            }
            else
            {
                MessageBox.Show("Unknown request type.");
                return;
            }

            try
            {
                using (SqlConnection connection = DatabaseConnection.GetConnection())
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ReferenceID", referenceID);
                        command.Parameters.AddWithValue("@ResidentID", residentID);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string details = "";

                                for (int i = 0; i < reader.FieldCount; i++)
                                {
                                    string value = reader.IsDBNull(i)
                                        ? "N/A"
                                        : reader[i].ToString();

                                    if (!reader.IsDBNull(i) && reader[i] is DateTime)
                                    {
                                        value = Convert.ToDateTime(reader[i])
                                            .ToString("dd/MM/yyyy");
                                    }

                                    details += reader.GetName(i) + ": " +
                                               value + Environment.NewLine;
                                }

                                MessageBox.Show(
                                    details,
                                    "My Request Details - " + referenceID,
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Request details not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load request details: " + ex.Message,
                    "My Request Details");
            }
        }

    }
}
