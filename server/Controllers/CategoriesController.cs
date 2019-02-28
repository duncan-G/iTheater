using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Dtos;
using Server.Helpers;
using Server.Models;

namespace Server.Controllers {
    [Authorize]
    [Route ("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase {
        DataContext _context;
        IMapper _entityDtoMapper;
        public CategoriesController (
            DataContext context,
            IMapper mapper
        ) {
            _context = context;
            _entityDtoMapper = mapper;
        }

        // POST /api/cateogires
        [HttpPost]
        public async Task<ActionResult<CategoryDto>> Create ([FromBody] CategoryDto categoryDto) {
            var category = _entityDtoMapper.Map<Category> (categoryDto);
            category.UserId = int.Parse (User.Identity.Name);
            await _context.Categories.AddAsync (category);
            await _context.SaveChangesAsync ();
            System.Console.WriteLine (User.Identity.Name);
            return Ok (_entityDtoMapper.Map<CategoryDto> (category));
        }

        // GET /api/categories
        // Prefetch 10 or so movies in each category
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> Get () {
            var userId = int.Parse (User.Identity.Name);
            var categories = _context.Categories.Where (category => category.UserId == userId);

            return Ok (_entityDtoMapper.Map<IEnumerable<CategoryDto>> (categories));
        }

        // DELETE /api/categories/{id}
        [HttpDelete ("{id}")]
        public ActionResult Delete (int id) {
            var userId = int.Parse (User.Identity.Name);
            var category = new Category () { Id = id, UserId = userId };
            _context.Categories.Attach (category);
            _context.Categories.Remove (category);
            _context.SaveChanges ();
            return Ok ();
        }

        // PUT /api/categories/{id}
        [HttpPut ("{id}")]
        public async Task<ActionResult<Category>> Put (int id, [FromBody] CategoryDto categoryDto) {
            var userId = int.Parse (User.Identity.Name);
            var category = await _context.Categories.SingleOrDefaultAsync (cat => cat.Id == id);

            if (category == null) {
                return BadRequest (new { message = "Category does not exist." });
            } else if (category.UserId != userId) {
                return BadRequest (new { message = "Unauthorized" });
            }

            category.Name = categoryDto.name;

            return Ok (_entityDtoMapper.Map<CategoryDto> (category));
        }

    }
}