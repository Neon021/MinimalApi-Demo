CREATE PROCEDURE [dbo].[spBand_Create]
	@name varchar(50),
	@genres varchar(50),
	@albums varchar(50)
AS
BEGIN
	INSERT INTO dbo.musicBand(Name,Genres,Albums)
		VALUES(@name,@genres,@albums);
END