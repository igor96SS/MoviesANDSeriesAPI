using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace Movies_SeriesAPI.Models
{
    public class Movies
    {
        [Column("MovieId")]
        public int Id { get; set; }
        public string MovieName { get; set; }
        public int? Year { get; set; }
        public bool Own { get; set; }

    }
}
