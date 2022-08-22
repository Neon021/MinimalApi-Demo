CREATE PROCEDURE [dbo].[spBand_Update]
	@Id int,
	@name varchar(50),
	@genres varchar(50),
	@albums varchar(50)
AS
BEGIN
	UPDATE dbo.musicBand
	SET Name = @name, Genres=@genres, Albums=@albums
	WHERE BandId=@Id
END