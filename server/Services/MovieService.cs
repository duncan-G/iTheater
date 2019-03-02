using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Server.Helpers;
using Server.Models;

namespace Server.Services {

    public interface IMovieService {
        IQueryable<Movie> GetAllInMovieList (int userId, int movieListId);
        IQueryable<Movie> GetAllInPublicList (int movieListId);
        Task<Movie> Create (int userId, Movie movie);
        Task<Movie> Update (int userId, int movieId, int rating);
        void Delete (int userId, int movieId);
    }

    public class MovieService : IMovieService {

        private DataContext _context;
        public MovieService (
            DataContext context
        ) {
            _context = context;
        }

        public IQueryable<Movie> GetAllInMovieList (int userId, int movieListId) {
            var movieList = _context.MovieLists.SingleOrDefault (_movieList => _movieList.Id == movieListId);

            if (movieList.Privacy && movieList.UserId != userId)
                throw new AppException ("Unauthorized");

            return _context.Movies.Where (_movie => _movie.MovieListId == movieListId);
        }

        public IQueryable<Movie> GetAllInPublicList (int movieListId) {
            var movieList = _context.MovieLists.SingleOrDefault (_movieList => _movieList.Id == movieListId);

            if (movieList.Privacy)
                throw new AppException ("Unauthorized");

            return _context.Movies.Where (_movie => _movie.MovieListId == movieListId);
        }

        public async Task<Movie> Create (int userId, Movie movie) {
            var movieListId = movie.MovieListId;

            if (await _context.Movies.AnyAsync (
                    _movie => (_movie.MoviesDbId == movie.MoviesDbId && _movie.MovieListId == movieListId)))
                throw new AppException ("Movie already exists in list!");

            movie.Created = DateTime.Now;

            await _context.Movies.AddAsync (movie);
            await _context.SaveChangesAsync ();
            return movie;
        }

        public async Task<Movie> Update (int userId, int movieId, int rating) {
            var movie = await _context.Movies.Include ("MovieList").SingleOrDefaultAsync (_movie => _movie.Id == movieId);
            if (movie == null)
                throw new AppException ("Movie does not exist!");

            if (movie.MovieList.UserId != userId)
                throw new AppException ("Unauthorized");

            movie.Rating = rating;
            await _context.SaveChangesAsync ();
            return movie;
        }

        public void Delete (int userId, int id) {
            var movie = _context.Movies.Include ("MovieList").SingleOrDefault (_movie => _movie.Id == id);
            if (movie == null)
                throw new AppException("Movie does not exist!");
                
            if (movie.MovieList.UserId != userId)
                throw new AppException ("Unauthorized");

            _context.Movies.Remove (movie);
            _context.SaveChangesAsync ();
        }
    }
}