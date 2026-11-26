-- Run in SSMS while connected to (localdb)\MSSQLLocalDB using Windows Authentication.
-- These checks only read server and database metadata.

SELECT
    @@SERVERNAME AS ConnectedServer,
    ORIGINAL_LOGIN() AS OriginalLogin,
    SUSER_SNAME() AS CurrentLogin,
    DB_ID(N'BarangayEServiceDB') AS DatabaseID,
    HAS_DBACCESS(N'BarangayEServiceDB') AS HasDatabaseAccess;

SELECT
    name AS DatabaseName,
    state_desc AS DatabaseState,
    user_access_desc AS UserAccess,
    is_read_only AS IsReadOnly
FROM sys.databases
WHERE name = N'BarangayEServiceDB';

SELECT
    name AS ServerLogin,
    type_desc AS LoginType,
    is_disabled AS IsDisabled
FROM sys.server_principals
WHERE name = SUSER_SNAME();

-- Run this batch only if HasDatabaseAccess above is 1.
USE [BarangayEServiceDB];
GO

SELECT
    DB_NAME() AS CurrentDatabase,
    USER_NAME() AS CurrentDatabaseUser,
    IS_MEMBER(N'db_owner') AS IsDatabaseOwner;

SELECT
    c.name AS ColumnName,
    t.name AS DataType,
    c.max_length AS MaxLengthBytes,
    c.is_nullable AS IsNullable
FROM sys.columns AS c
INNER JOIN sys.types AS t ON c.user_type_id = t.user_type_id
WHERE c.object_id = OBJECT_ID(N'dbo.Residents', N'U')
ORDER BY c.column_id;
