
using Microsoft.AspNetCore.Mvc;

namespace EFCoreRelationshipsTutorial.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly DataContext _context;

        public CharacterController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Character>>> Get(int userId)
        {
            var characters = await _context.Characters
                .Where(c => c.UserId == userId)
                .ToListAsync();

            return Ok(characters);
        }

        [HttpPost]
        public async Task<ActionResult<List<Character>>> Create(Character character)
        {
            _context.Characters.Add(character);
            await _context.SaveChangesAsync();

            return Ok(await _context.Characters.Where(c => c.UserId == character.UserId).ToListAsync());
        }
    }
}
