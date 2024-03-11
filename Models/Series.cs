namespace Movies_SeriesAPI.Models
{
    public class Series
    {
        public int SerieID { get; set; }
        public string SerieName { get; set; }
        public int? StartYear { get; set; }
        public int? EndYear { get; set; }
    }
}
