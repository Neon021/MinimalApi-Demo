if not exists( select 1 from dbo.musicBand)
begin 
	insert into dbo.musicBand(name,genres,albums)
		values('Radiohead','alternative','Amnesiac'),
		('Pink Floyd','Rock','Final Cut'),
		('Daft Punk','Electronic','Alive 2007');
end