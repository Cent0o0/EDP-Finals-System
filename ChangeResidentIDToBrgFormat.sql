USE [BarangayEServiceDB];
GO

SET XACT_ABORT ON;
BEGIN TRANSACTION;

BEGIN TRY
    -- Build a stable mapping so every request keeps its current resident link.
    CREATE TABLE #ResidentIDMap
    (
        OldResidentID INT NOT NULL PRIMARY KEY,
        NewResidentID NVARCHAR(20) NOT NULL UNIQUE
    );

    INSERT INTO #ResidentIDMap (OldResidentID, NewResidentID)
    SELECT ResidentID,
           N'BRG-RES-' + RIGHT(N'00' + CONVERT(NVARCHAR(20), ROW_NUMBER() OVER (ORDER BY ResidentID)), 2)
    FROM dbo.Residents;

    -- Add temporary string columns to the resident table and its three known child tables.
    ALTER TABLE dbo.Residents ADD ResidentID_New NVARCHAR(20) NULL;
    ALTER TABLE dbo.EquipmentReservations ADD ResidentID_New NVARCHAR(20) NULL;
    ALTER TABLE dbo.Complaints ADD ResidentID_New NVARCHAR(20) NULL;
    ALTER TABLE dbo.CertificateRequests ADD ResidentID_New NVARCHAR(20) NULL;

    UPDATE resident
    SET ResidentID_New = idMap.NewResidentID
    FROM dbo.Residents AS resident
    INNER JOIN #ResidentIDMap AS idMap ON resident.ResidentID = idMap.OldResidentID;

    UPDATE reservation
    SET ResidentID_New = idMap.NewResidentID
    FROM dbo.EquipmentReservations AS reservation
    INNER JOIN #ResidentIDMap AS idMap ON reservation.ResidentID = idMap.OldResidentID;

    UPDATE complaint
    SET ResidentID_New = idMap.NewResidentID
    FROM dbo.Complaints AS complaint
    INNER JOIN #ResidentIDMap AS idMap ON complaint.ResidentID = idMap.OldResidentID;

    UPDATE request
    SET ResidentID_New = idMap.NewResidentID
    FROM dbo.CertificateRequests AS request
    INNER JOIN #ResidentIDMap AS idMap ON request.ResidentID = idMap.OldResidentID;

    IF EXISTS (SELECT 1 FROM dbo.Residents WHERE ResidentID_New IS NULL)
       OR EXISTS (SELECT 1 FROM dbo.EquipmentReservations WHERE ResidentID_New IS NULL)
       OR EXISTS (SELECT 1 FROM dbo.Complaints WHERE ResidentID_New IS NULL)
       OR EXISTS (SELECT 1 FROM dbo.CertificateRequests WHERE ResidentID_New IS NULL)
    BEGIN
        THROW 50001, 'At least one ResidentID could not be mapped. No changes were committed.', 1;
    END;

    -- Remove foreign keys before replacing their referenced key columns.
    ALTER TABLE dbo.EquipmentReservations DROP CONSTRAINT FK_EquipmentReservations_Residents;
    ALTER TABLE dbo.Complaints DROP CONSTRAINT FK_Complaints_Residents;
    ALTER TABLE dbo.CertificateRequests DROP CONSTRAINT FK_CertificateRequests_Residents;

    -- Remove the old identity key and its duplicate unique constraint.
    ALTER TABLE dbo.Residents DROP CONSTRAINT [PK__Resident__07FB00CFE548279];
    ALTER TABLE dbo.Residents DROP CONSTRAINT [UQ__Resident__536C85E4F525DF05];

    ALTER TABLE dbo.Residents DROP COLUMN ResidentID;
    ALTER TABLE dbo.EquipmentReservations DROP COLUMN ResidentID;
    ALTER TABLE dbo.Complaints DROP COLUMN ResidentID;
    ALTER TABLE dbo.CertificateRequests DROP COLUMN ResidentID;

    EXEC sys.sp_rename N'dbo.Residents.ResidentID_New', N'ResidentID', N'COLUMN';
    EXEC sys.sp_rename N'dbo.EquipmentReservations.ResidentID_New', N'ResidentID', N'COLUMN';
    EXEC sys.sp_rename N'dbo.Complaints.ResidentID_New', N'ResidentID', N'COLUMN';
    EXEC sys.sp_rename N'dbo.CertificateRequests.ResidentID_New', N'ResidentID', N'COLUMN';

    ALTER TABLE dbo.Residents ALTER COLUMN ResidentID NVARCHAR(20) NOT NULL;

    -- Re-create the resident key and the three foreign key relationships.
    ALTER TABLE dbo.Residents
        ADD CONSTRAINT [PK__Resident__07FB00CFE548279] PRIMARY KEY (ResidentID);
    ALTER TABLE dbo.Residents
        ADD CONSTRAINT [UQ__Resident__536C85E4F525DF05] UNIQUE (ResidentID);

    ALTER TABLE dbo.EquipmentReservations
        ADD CONSTRAINT FK_EquipmentReservations_Residents
        FOREIGN KEY (ResidentID) REFERENCES dbo.Residents (ResidentID);
    ALTER TABLE dbo.Complaints
        ADD CONSTRAINT FK_Complaints_Residents
        FOREIGN KEY (ResidentID) REFERENCES dbo.Residents (ResidentID);
    ALTER TABLE dbo.CertificateRequests
        ADD CONSTRAINT FK_CertificateRequests_Residents
        FOREIGN KEY (ResidentID) REFERENCES dbo.Residents (ResidentID);

    COMMIT TRANSACTION;

    SELECT ResidentID, FullName
    FROM dbo.Residents
    ORDER BY ResidentID;
END TRY
BEGIN CATCH
    IF @@TRANCOUNT > 0
    BEGIN
        ROLLBACK TRANSACTION;
    END;

    THROW;
END CATCH;
GO
