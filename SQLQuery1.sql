USE [BarangayEServiceDB];
GO

SELECT
    c.name AS ColumnName,
    t.name AS DataType,
    c.max_length AS MaxLength,
    c.is_nullable AS IsNullable,
    dc.definition AS DefaultValue
FROM sys.columns AS c
JOIN sys.types AS t
    ON c.user_type_id = t.user_type_id
LEFT JOIN sys.default_constraints AS dc
    ON c.default_object_id = dc.object_id
WHERE c.object_id = OBJECT_ID(N'dbo.CertificateRequests')
ORDER BY c.column_id;

CREATE TABLE dbo.Complaints
    (
        ComplaintID INT IDENTITY(1,1) NOT NULL
            CONSTRAINT PK_Complaints PRIMARY KEY,

        ResidentID INT NOT NULL,
        Category NVARCHAR(100) NOT NULL,
        IncidentLocation NVARCHAR(200) NOT NULL,
        Description NVARCHAR(1000) NOT NULL,
        IncidentDate DATETIME2 NOT NULL,
        Status NVARCHAR(40) NOT NULL
            CONSTRAINT DF_Complaints_Status DEFAULT (N'Pending'),
        DateSubmitted DATETIME2 NOT NULL
            CONSTRAINT DF_Complaints_DateSubmitted DEFAULT (SYSDATETIME()),

        CONSTRAINT FK_Complaints_Residents
            FOREIGN KEY (ResidentID)
            REFERENCES dbo.Residents (ResidentID)
    );

    SELECT TABLE_SCHEMA, TABLE_NAME
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_TYPE = 'BASE TABLE'
  AND TABLE_NAME LIKE '%Equipment%Reserv%';

  USE [BarangayEServiceDB];
GO

SELECT
    TABLE_NAME,
    COLUMN_NAME,
    DATA_TYPE,
    IS_NULLABLE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_SCHEMA = 'dbo'
  AND TABLE_NAME IN ('EquipmentReservation', 'EquipmentReservations')
ORDER BY TABLE_NAME, ORDINAL_POSITION;

IF COL_LENGTH(N'dbo.CertificateRequests', N'Purpose') IS NULL
    ALTER TABLE dbo.CertificateRequests ADD Purpose NVARCHAR(200) NULL;
GO

IF COL_LENGTH(N'dbo.CertificateRequests', N'AdditionalRemarks') IS NULL
    ALTER TABLE dbo.CertificateRequests ADD AdditionalRemarks NVARCHAR(1000) NULL;
GO

SELECT
    COLUMN_NAME,
    DATA_TYPE,
    IS_NULLABLE,
    COLUMN_DEFAULT
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'Residents'
ORDER BY ORDINAL_POSITION;

-- 2. Find every foreign key referencing Residents
SELECT
    fk.name AS ForeignKeyName,
    OBJECT_NAME(fk.parent_object_id) AS ReferencingTable,
    COL_NAME(
        fkc.parent_object_id,
        fkc.parent_column_id
    ) AS ReferencingColumn,
    OBJECT_NAME(fk.referenced_object_id) AS ReferencedTable,
    COL_NAME(
        fkc.referenced_object_id,
        fkc.referenced_column_id
    ) AS ReferencedColumn
FROM sys.foreign_keys fk
INNER JOIN sys.foreign_key_columns fkc
    ON fk.object_id = fkc.constraint_object_id
WHERE fk.referenced_object_id = OBJECT_ID('dbo.Residents');

-- 3. Check existing resident records
SELECT *
FROM dbo.Residents
ORDER BY ResidentID;
GO

SELECT
    TABLE_NAME,
    COLUMN_NAME,
    DATA_TYPE,
    CHARACTER_MAXIMUM_LENGTH,
    IS_NULLABLE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME IN (
    'EquipmentReservations',
    'Complaints',
    'CertificateRequests'
)
ORDER BY TABLE_NAME, ORDINAL_POSITION;

-- Check existing records in each dependent table
SELECT 'EquipmentReservations' AS TableName, COUNT(*) AS TotalRecords
FROM dbo.EquipmentReservations

UNION ALL

SELECT 'Complaints', COUNT(*)
FROM dbo.Complaints

UNION ALL

SELECT 'CertificateRequests', COUNT(*)
FROM dbo.CertificateRequests;
GO

-- 1. Check primary keys and identity columns
SELECT
    t.name AS TableName,
    c.name AS ColumnName,
    ty.name AS DataType,
    c.max_length,
    c.is_identity,
    CASE WHEN pk.column_id IS NOT NULL
         THEN 'PRIMARY KEY'
         ELSE ''
    END AS KeyType
FROM sys.tables t
INNER JOIN sys.columns c
    ON t.object_id = c.object_id
INNER JOIN sys.types ty
    ON c.user_type_id = ty.user_type_id
LEFT JOIN (
    SELECT ic.object_id, ic.column_id
    FROM sys.indexes i
    INNER JOIN sys.index_columns ic
        ON i.object_id = ic.object_id
       AND i.index_id = ic.index_id
    WHERE i.is_primary_key = 1
) pk
    ON c.object_id = pk.object_id
   AND c.column_id = pk.column_id
WHERE t.name IN (
    'Residents',
    'CertificateRequests',
    'Complaints',
    'EquipmentReservations'
)
ORDER BY t.name, c.column_id;

-- 2. Check all columns in EquipmentReservations
SELECT
    COLUMN_NAME,
    DATA_TYPE,
    CHARACTER_MAXIMUM_LENGTH,
    IS_NULLABLE
FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'EquipmentReservations'
ORDER BY ORDINAL_POSITION;

-- 3. Inspect the existing complaint's ResidentID only
SELECT
    ComplaintID,
    ResidentID
FROM dbo.Complaints;
GO


USE BarangayEServiceDB;
GO

-- Primary key and foreign key constraint names
SELECT
    t.name AS TableName,
    kc.name AS ConstraintName,
    kc.type_desc AS ConstraintType
FROM sys.key_constraints kc
INNER JOIN sys.tables t
    ON kc.parent_object_id = t.object_id
WHERE t.name IN (
    'Residents',
    'CertificateRequests',
    'Complaints',
    'EquipmentReservations'
)

UNION ALL

SELECT
    OBJECT_NAME(parent_object_id),
    name,
    'FOREIGN KEY'
FROM sys.foreign_keys
WHERE referenced_object_id = OBJECT_ID('dbo.Residents');
GO




USE BarangayEServiceDB;
GO

-- Identify columns covered by primary and unique constraints
SELECT
    t.name AS TableName,
    kc.name AS ConstraintName,
    c.name AS ColumnName,
    kc.type_desc AS ConstraintType
FROM sys.key_constraints kc
INNER JOIN sys.tables t
    ON kc.parent_object_id = t.object_id
INNER JOIN sys.index_columns ic
    ON kc.parent_object_id = ic.object_id
   AND kc.unique_index_id = ic.index_id
INNER JOIN sys.columns c
    ON ic.object_id = c.object_id
   AND ic.column_id = c.column_id
WHERE t.name = 'Residents'
ORDER BY kc.name, ic.key_ordinal;

-- Check triggers on the affected tables
SELECT
    OBJECT_NAME(parent_id) AS TableName,
    name AS TriggerName,
    is_disabled
FROM sys.triggers
WHERE parent_id IN (
    OBJECT_ID('dbo.Residents'),
    OBJECT_ID('dbo.EquipmentReservations'),
    OBJECT_ID('dbo.Complaints'),
    OBJECT_ID('dbo.CertificateRequests')
);
GO
