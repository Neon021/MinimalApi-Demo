CREATE TABLE [dbo].[musicBand]
(
	[BandId] INT  PRIMARY KEY IDENTITY, 
    [Name] VARCHAR(50) NOT NULL, 
    [Genres] VARCHAR(50) NOT NULL, 
    [Albums] VARCHAR(50) NULL
)
