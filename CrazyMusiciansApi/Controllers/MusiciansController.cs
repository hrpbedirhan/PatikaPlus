using CrazyMusiciansApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CrazyMusiciansApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusiciansController : ControllerBase
    {
        private static List<Musician> _musicians = new List<Musician>
        {
            new Musician{ Id = 1, Name = "Ahmet Çalgı", Profession = "Ünlü Çalgı Çalar", FunFact = "Her zaman yanlış nota çalar ama çok eğlenceli" },
            new Musician{ Id = 2, Name = "Zeynep Melodi", Profession = "Popüler Melodi Yazarı", FunFact = "Şarkıları yanlış anlaşılır ama çok popüler" },
            new Musician{ Id = 3, Name = "Cemil Akor", Profession = "Çılgın Akorist", FunFact = "Akorları sık değiştirir, ama şaşırtıcı derecede yetenekli" },
            new Musician{ Id = 4, Name = "Fatma Nota", Profession = "Sürpriz Nota Üreticisi", FunFact = "Nota hazırlarken sürekli sürprizler hazırlar" },
            new Musician{ Id = 5, Name = "Hasan Ritim", Profession = "Ritim Canavarı", FunFact = "Her ritmi kendi tarzında yapar, hiç uymaz ama komiktir" },
            new Musician{ Id = 6, Name = "Elif Armoni", Profession = "Armoni Ustası", FunFact = "Armonilerini bazen yanlış çalar ama çok yaratıcıdır" },
            new Musician{ Id = 7, Name = "Al Perde", Profession = "Perde Uygulayıcı", FunFact = "Her perdeyi farklı şekilde çalar, her zaman sürprizlidir" },
            new Musician{ Id = 8, Name = "Ayşe Rezonans", Profession = "Rezonans Uzmanı", FunFact = "Rezonans konusunda uzman, ama bazen çok gürültü çıkarır" },
            new Musician{ Id = 9, Name = "Murat Ton", Profession = "Tonlama Meraklısı", FunFact = "Tonlamalarındaki farklılıklar bazen komik, ama oldukça ilginç" },
            new Musician{ Id = 10, Name = "Selin Akor", Profession = "Akor Sihirbazı", FunFact = "Akorları değiştirdiğinde bazen sihirli bir hava yaratır" }
        };

        // Get All
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_musicians);
        }

        // Get by Id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var musician = _musicians.First(m => m.Id == id);

            if (musician == null)
                return NotFound();

            return Ok(musician);
        }

        // Search by Name [FromQuery]
        [HttpGet("search")]
        public IActionResult SearchMusicians([FromQuery] string name)
        {
            var result = _musicians.Where(m => m.Name.Contains(name, StringComparison.OrdinalIgnoreCase)).ToList();

            if (!result.Any())
                return NotFound("No musicians found with the given name.");

            return Ok(result);
        }

        // Create
        [HttpPost]
        public IActionResult Post([FromBody] Musician musician)
        {
            musician.Id = _musicians.Max(m => m.Id) + 1;
            _musicians.Add(musician);

            return CreatedAtAction(nameof(Get), new { id = musician.Id }, musician);
        }

        // Update (Put)
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Musician updatedMusician)
        {
            var musician = _musicians.FirstOrDefault(m => m.Id == id);

            if (musician == null)
                return NotFound();

            musician.Name = updatedMusician.Name;
            musician.Profession = updatedMusician.Profession;
            musician.FunFact = updatedMusician.FunFact;

            return NoContent();
        }

        // Partial Update (Patch)
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, [FromBody] string funfact)
        {
            var musician = _musicians.FirstOrDefault(m => m.Id == id);
            if (musician == null)
                return NotFound();

            musician.FunFact = funfact;

            return NoContent();
        }

        // Delete
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var musician = _musicians.FirstOrDefault(m => m.Id == id);

            if (musician == null)
                return NotFound();

            _musicians.Remove(musician);
            return NoContent();
        }
    }
}
