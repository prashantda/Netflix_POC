
CREATE OR ALTER PROCEDURE InsertTvShow
(
    @TvShowId uniqueidentifier,
    @TvShowName nvarchar(63),
    @Seasons int,
    @Description nvarchar(400),
    @CreatorName nvarchar(40),
    @Language nvarchar(15),
    @ImagePath nvarchar(150),
    @Rating float = NULL,
    @TrailerPath nvarchar(150),
    @ReleaseDate datetime,
    @Access nvarchar(50)
)
AS
BEGIN
    INSERT INTO [Netflix].[dbo].[TvShows] (TvShowId, TvShowName, Seasons, Description, CreatorName, Language, ImagePath, Rating, TrailerPath,  ReleaseDate,  Access)
    VALUES (@TvShowId, @TvShowName, @Seasons, @Description, @CreatorName, @Language, @ImagePath, @Rating, @TrailerPath,  @ReleaseDate,  @Access)
END

GO

CREATE OR ALTER PROCEDURE GetTvShow
    @TvShowId uniqueidentifier
AS
BEGIN
    SELECT *
    FROM [Netflix].[dbo].[TvShows]
    WHERE TvShowId = @TvShowId
END





GO
CREATE OR ALTER PROCEDURE DeleteTvShows
    @TvShowId uniqueidentifier
AS
BEGIN
    DELETE 
    FROM [Netflix].[dbo].[TvShows]
    WHERE TvShowId = @TvShowId
END

