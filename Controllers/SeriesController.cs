using Microsoft.AspNetCore.Mvc;
using Movies_SeriesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace Movies_SeriesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeriesController : ControllerBase
    {
        private readonly SeriesContext _context;
        public SeriesController(SeriesContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Series>> GetAllSeries()
        {
            return _context.Series.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Series> GetSeriesById(int id)
        {
            var serie = _context.Series.Find(id);
            if (serie == null)
            {
                return NotFound();
            }

            return serie;
        }

        [HttpPost]
        public ActionResult<Series> CreateSerie(Series serie)
        {
            _context.Series.Add(serie);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetSeriesById), new { id = serie.SerieID}, serie);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateSerie(int id, Series serie) 
        {
            if(id != serie.SerieID) 
            {
                return BadRequest();
            }

            // inform that entity was modified
            _context.Entry(serie).State = EntityState.Modified;
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSeries(int id)
        {
            var serie = _context.Series.Find(id);
            if(serie == null)
            {
                return NotFound();
            }
            _context.Series.Remove(serie);
            _context.SaveChanges();

            return NoContent();
        }

    }
}
