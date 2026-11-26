USE [BarangayEServiceDB];
GO

-- Add request-specific purpose and remarks fields to the existing request table.
-- Existing request rows and the ResidentID relationship are preserved.
IF OBJECT_ID(N'dbo.CertificateRequests', N'U') IS NULL
BEGIN
    THROW 50002, 'dbo.CertificateRequests was not found in BarangayEServiceDB.', 1;
END;
GO

IF COL_LENGTH(N'dbo.CertificateRequests', N'Purpose') IS NULL
BEGIN
    ALTER TABLE dbo.CertificateRequests
    ADD Purpose NVARCHAR(200) NULL;
END;
GO

IF COL_LENGTH(N'dbo.CertificateRequests', N'AdditionalRemarks') IS NULL
BEGIN
    ALTER TABLE dbo.CertificateRequests
    ADD AdditionalRemarks NVARCHAR(1000) NULL;
END;
GO
