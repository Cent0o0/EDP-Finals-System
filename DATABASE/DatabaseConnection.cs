using Microsoft.Data.SqlClient;

namespace Barangay_E_Service_System.DATA
{
    public class DatabaseConnection
    {
        private static readonly string connectionString = @"Server=(localdb)\MSSQLLocalDB;Database=BarangayEServiceDB;Integrated Security=True;TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
