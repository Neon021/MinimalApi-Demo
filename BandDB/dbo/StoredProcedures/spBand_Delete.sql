CREATE PROCEDURE [dbo].[spBand_Delete]
	@Id int 
AS
BEGIN
	DELETE FROM dbo.musicBand
	WHERE BandId=@Id
END