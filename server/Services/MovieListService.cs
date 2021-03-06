using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Server.Dtos;
using Server.Helpers;
using Server.Models;

namespace Server.Services {

    public interface IMovieListService {
        IQueryable<MovieList> GetAllByUserId (int userId);
        IQueryable<MovieList> GetAllPublic ();
        MovieList Get (int userId, string slug);
        MovieList GetPublic (string slug);
        Task<MovieList> Create (int userId, MovieList movieList);
        Task<MovieList> Update (int userId, int movieListId, string name);
        Task<MovieList> UpdateDefaultImage (int userId, int movieListId, string defaultImageUrl);
        void Delete (int userId, int movieListId);
    }

    public class MovieListService : IMovieListService {
        private DataContext _context;

        public MovieListService (DataContext context) {
            _context = context;
        }

        public IQueryable<MovieList> GetAllByUserId (int userId) {
            return _context.MovieLists.Where (_movieList => _movieList.UserId == userId);
        }

        public IQueryable<MovieList> GetAllPublic () {
            return _context.MovieLists.Where (_movieList => _movieList.Privacy == false);
        }

        public MovieList Get (int userId, string slug) {
            return _context.MovieLists.SingleOrDefault (_movieList =>
                (_movieList.Slug == slug && _movieList.UserId == userId));
        }

        public MovieList GetPublic (string slug) {
            return _context.MovieLists.SingleOrDefault (_movieList => _movieList.Slug == slug);
        }

        public Task<MovieList> Get (string slug) {
            return _context.MovieLists.SingleOrDefaultAsync(_movieList => _movieList.Slug == slug);
        }
        
        public async Task<MovieList> Create (int userId, MovieList movieList) {
            var name = movieList.Name;
            if (string.IsNullOrWhiteSpace (name))
                throw new AppException ("Movie list name is invalid!");

            if (await _context.MovieLists.AnyAsync (_movieList => (_movieList.Name == name && _movieList.UserId == userId)))
                throw new AppException ("Movie List already exists!");

            movieList.UserId = userId;
            movieList.Created = DateTime.Now;

            await _context.MovieLists.AddAsync (movieList);
            await _context.SaveChangesAsync ();
            movieList.Slug = GeneralHelpers.Slugify (name, movieList.Id);
            await _context.SaveChangesAsync ();
            return movieList;
        }

        public async Task<MovieList> Update (int userId, int movieListId, string name) {
            if (string.IsNullOrWhiteSpace (name))
                throw new AppException ("Movie list name is invalid!");

            var movieList = await _context.MovieLists.SingleOrDefaultAsync (list => (list.Id == movieListId && list.UserId == userId));
            if (movieList == null) {
                throw new AppException ("Movie list does not exist!");
            }

            movieList.Name = name;
            movieList.Slug = GeneralHelpers.Slugify (name, movieListId);
            await _context.SaveChangesAsync ();
            return movieList;
        }

        public async Task<MovieList> UpdateDefaultImage (int userId, int movieListId, string defaultImageUrl) {
            if (string.IsNullOrWhiteSpace (defaultImageUrl))
                throw new AppException ("Invalid image url.");

            var movieList = await _context.MovieLists.SingleOrDefaultAsync (list => (list.Id == movieListId));
            if (movieList == null) {
                throw new AppException ("Movie list does not exist!");
            }
            movieList.DefaultImageUrl = defaultImageUrl;
            await _context.SaveChangesAsync ();

            return movieList;
        }

        public void Delete (int userId, int movieListId) {
            var movieList = new MovieList () { Id = movieListId, UserId = userId };
            _context.MovieLists.Attach (movieList);
            _context.MovieLists.Remove (movieList);
            _context.SaveChanges ();
        }
    }
}