using Microsoft.AspNetCore.Mvc;
using Server.Models;

namespace Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly DataContext _context;
        
        public MoviesController(
            DataContext context
        )
        {
            _context = context;
        }

        // CREATE /api/movies
        // Add movie to category
        

        // GET /api/movies/{category}
        // Fetch all movies in category

        // GET /api/movies/{id}
        // Fetch movie by id

        // PUT /api/movies/{id}
        // Update movie by id

        // DELETE /api/movies/{id}
        // Delete movie by id
        
    }
}