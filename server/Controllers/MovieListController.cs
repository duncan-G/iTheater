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
using Server.Services;

namespace Server.Controllers {
    [Authorize]
    [Route ("api/[controller]")]
    [ApiController]
    public class MovieListsController : ControllerBase {
        IMapper _entityDtoMapper;
        IMovieListService _movieListService;

        public MovieListsController (
            IMovieListService movieListService,
            IMapper mapper
        ) {
            _movieListService = movieListService;
            _entityDtoMapper = mapper;
        }

        // POST /api/cateogires
        [HttpPost]
        public async Task<ActionResult<MovieListDto>> Create ([FromBody] MovieListDto movieListDto) {
            var movieList = _entityDtoMapper.Map<MovieList> (movieListDto);
            var userId = int.Parse (User.Identity.Name);
            try {
                await _movieListService.Create (userId, movieList);
                return Ok (_entityDtoMapper.Map<MovieListDto> (movieList));
            } catch (AppException ex) {
                return BadRequest (new { message = ex.Message });
            }
        }

        // GET /api/categories
        // Prefetch 10 or so movies in each category
        [HttpGet]
        public ActionResult<IEnumerable<MovieListDto>> Get ([FromQuery (Name = "privacy")] string privacy) {
            var userId = int.Parse (User.Identity.Name);

            IEnumerable<MovieList> movieLists;
            if (privacy == "public") {
                movieLists = _movieListService.GetAllPublic ();
            } else {
                movieLists = _movieListService.GetAllByUserId (userId);
            }

            return Ok (_entityDtoMapper.Map<IEnumerable<MovieListDto>> (movieLists));
        }

        // DELETE /api/categories/{movieListId}
        [HttpDelete ("{movieListId}")]
        public ActionResult Delete (int movieListId) {
            var userId = int.Parse (User.Identity.Name);
            try {
                _movieListService.Delete (userId, movieListId);
                return Ok ();
            } catch (AppException ex) {
                return BadRequest (new { message = ex.Message });
            }
        }

        // PUT /api/categories/{movieListId}
        [HttpPut ("{movieListId}")]
        public async Task<ActionResult<MovieListDto>> Put (int movieListId, [FromBody] MovieListDto movieListDto) {
            var userId = int.Parse (User.Identity.Name);

            try {
                var movieList = await _movieListService.Update (userId, movieListId, movieListDto.name);
                return Ok (_entityDtoMapper.Map<MovieListDto> (movieList));
            } catch (AppException ex) {
                return BadRequest (new { message = ex.Message });
            }
        }

    }
}