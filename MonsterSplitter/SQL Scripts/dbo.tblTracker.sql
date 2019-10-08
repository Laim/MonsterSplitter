CREATE TABLE [dbo].[tblTracker]
(
	[TID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FileName] NCHAR(500) NOT NULL, 
    [FileSize] NCHAR(50) NOT NULL, 
    [SplitDate] NCHAR(11) NOT NULL
)
