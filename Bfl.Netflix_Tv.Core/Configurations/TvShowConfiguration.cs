using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bfl.Netflix_Tv.Core.Configurations
{
    public static class TvShowConfiguration
    {

        public static string InsertSP { get; } = "InsertTvShow";
        public static string UpdateSP { get; } = "UpdateTvShow";
        public static string DeleteSP { get; } = "DeleteTvShows";
        public static string GetSP { get; } = "GetTvShow";
        public static string GetAllSP { get; } = "GetAllShow";
        public static string TvShowId { get; } = "TvShowId";
        public static string TvShowName { get; } = "TvShowName";
        public static string Seasons { get; } = "Seasons";
        public static string Description { get; } = "Description";
        public static string CreatorName { get; } = "CreatorName";
        public static string Language { get; } = "Language";
        public static string ImagePath { get; } = "ImagePath";
        public static string Rating { get; } = "Rating";
        public static string TrailerPath { get; } = "TrailerPath";
        public static string ReleaseDate { get; } = "ReleaseDate";
        public static string Access { get; } = "Access";

    }
}
