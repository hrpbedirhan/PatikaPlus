using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Survivor.Model;
using Survivor.Model.Entities;

namespace Survivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitorController : ControllerBase
    {
        private readonly SurvivorDbContext _context;

        public CompetitorController(SurvivorDbContext context)
        {
            _context = context;
        }

        // GET: /api/Competitor
        [HttpGet]
        public IActionResult Get()
        {
            var competitors = _context.Competitors.ToList();
            return Ok(competitors);
        }

        // GET: /api/Competitor/{id}
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var competitor = _context.Competitors.Find(id);
            if (competitor == null) return NotFound();
            return Ok(competitor);
        }

        // GET: /api/Competitor/categories/{categoryId}
        [HttpGet("categories/{categoryId}")]
        public IActionResult GetCompetitorsByCategory(int categoryId)
        {
            var competitors = _context.Competitors
                                      .Where(c => c.CategoryId == categoryId)
                                      .ToList();
            return Ok(competitors);
        }

        // POST: /api/Competitor
        [HttpPost]
        public IActionResult CreateCompetitor([FromBody] Competitor competitor)
        {
            _context.Competitors.Add(competitor);
            _context.SaveChanges();
            return Ok(competitor);
        }

        // PUT: /api/Competitor
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Competitor competitor)
        {
            var _competitor = _context.Competitors.Find(id);
            if (_competitor == null) return NotFound();
            
            _competitor.FirstName = competitor.FirstName;
            _competitor.LastName = competitor.LastName;
            _competitor.CategoryId = competitor.CategoryId;
            _competitor.ModifiedDate = DateTime.Now;

            _context.SaveChanges();
            return Ok(_competitor);
        }

        // DELETE: /api/Competitor/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var _competitor = _context.Competitors.Find(id);

            if (_competitor == null) return NotFound();
            
            _context.Competitors.Remove(_competitor);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
