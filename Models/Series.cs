using System.ComponentModel.DataAnnotations;

namespace Movies_SeriesAPI.Models
{
    public class Series
    {
        [Key] //.net core expects a property with the name Id
        // or we can explicitly specify which property is a key
        public int SerieID { get; set; }
        public string SerieName { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
        public int? OwnSeason { get; set;}
        public int? LastSeason { get; set;}
        public int? LastEpisode { get; set; }
    }
}
