using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly DataContext _context;
        public UsersController(DataContext context)
        {
            _context = context;

        }

        [HttpGet] // Retrieves user information
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers() // need to await when making use of async
        {
                return await _context.Users.ToListAsync();
        }

        [HttpGet("{id}")] // Retrieves user information with specific id
        public async Task<ActionResult<AppUser>> GetUser(int id)
        {
                return await _context.Users.FindAsync(id);
        }

    }
}