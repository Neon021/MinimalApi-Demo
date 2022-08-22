CREATE PROCEDURE [dbo].[spBand_Get]
	@Id int
AS
BEGIN
	SELECT *FROM [dbo].musicBand
	WHERE BandId = @Id;
END