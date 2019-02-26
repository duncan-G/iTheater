using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Helpers;
using Server.Models;

namespace Server.Controllers {
    [Authorize]
    [Route ("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase {
        DataContext _context;
        public CategoriesController (
            DataContext context
        ) {
            _context = context;
        }

        // CREATE /api/cateogires
        // Add new category
        [HttpPost]
        public async Task<ActionResult<Category>> Create ([FromBody] Category category) {

            return Ok (new {
                id = 1,
                    name = "I'm testing",
                    userId = "userid"
            });
        }

        // GET /api/categories
        // Fetch list of categories for user
        // Prefetch 10 or so movies in each category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<string>>> Get () {
            return Ok (new string[] { "value1", "value2" });
        }

        // DELETE /api/categories/{id}
        // Delete category
        [HttpDelete ("{id}")]
        public void Delete (int id) {

        }

        // PUT /api/categories/{id}
        // Update category
        [HttpPut ("{id}")]
        public async Task<ActionResult<Category>> Put (int id) {
            return Ok (new {
                id = 1,
                    name = "I'm testing",
                    userId = "userid"
            });
        }

    }
}