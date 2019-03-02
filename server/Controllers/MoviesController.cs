using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Server.Dtos;
using Server.Helpers;
using Server.Models;
using Server.Services;

namespace Server.Controllers {
    [Authorize]
    [Route ("api/[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase {
        private IMapper _entityDtoMapper;
        private IMovieService _movieService;
        public MoviesController (
            IMapper mapper,
            IMovieService movieService
        ) {
            _entityDtoMapper = mapper;
            _movieService = movieService;
        }

        // CREATE /api/movies
        [HttpPost]
        public async Task<ActionResult<MovieDto>> Create ([FromBody] MovieDto movieDto) {
            var movie = _entityDtoMapper.Map<Movie> (movieDto);
            var userId = int.Parse (User.Identity.Name);
            try {
                await _movieService.Create (userId, movie);
                return Ok (_entityDtoMapper.Map<MovieDto> (movie));
            } catch (AppException ex) {
                return BadRequest (new { message = ex.Message });
            }
        }

        // PUT /api/movies/{id}
        [HttpPut ("{id}")]
        public async Task<ActionResult<MovieDto>> Put (int id, [FromBody] MovieDto movieDto) {
            var userId = int.Parse (User.Identity.Name);

            try {
                var movie = await _movieService.Update (userId, id, movieDto.rating);
                return Ok (_entityDtoMapper.Map<MovieDto> (movie));
            } catch (AppException ex) {
                return BadRequest (new { message = ex.Message });
            }
        }

        // DELETE /api/movies/{id}
        [HttpDelete ("{id}")]
        public ActionResult Delete (int id) {
            var userId = int.Parse (User.Identity.Name);
            try {
                _movieService.Delete (userId, id);
                return Ok ();
            } catch (AppException ex) {
                return BadRequest (new { message = ex.Message });
            }
        }
    }
}