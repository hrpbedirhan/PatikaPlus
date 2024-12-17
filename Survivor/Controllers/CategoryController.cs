using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Survivor.Model;
using Survivor.Model.Entities;

namespace Survivor.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly SurvivorDbContext _context;

        public CategoryController(SurvivorDbContext context)
        {
            _context = context;
        }

        // GET : /api/Category
        [HttpGet]
        public IActionResult Get()
        {
            var categories = _context.Categories.ToList();
            return Ok(categories);
        }

        // GET : /api/Category/{id}
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var _category = _context.Categories.Find(id);
            if (_category == null) return NotFound();
            return Ok(_category);
        }

        // POST : /api/Category
        [HttpPost]
        public IActionResult Post([FromBody] Category category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = category.Id }, category);
        }

        // PUT : /api/Category/{id}
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Category category)
        {
            var _category = _context.Categories.Find(id);
            if (_category == null) return NotFound();

            _category.Name = category.Name;
            _category.ModifiedDate = DateTime.Now;

            _context.SaveChanges();
            return NoContent();
        }

        // DELETE : /api/Category/{id}
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var _category = _context.Categories.Find(id);
            if (_category == null) return NotFound();

            _context.Categories.Remove(_category);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
