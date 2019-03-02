import { movies } from "./movies";
declare var require;
var slugify = require("slugify");

export const movieLists = [
  "Horror",
  "Sci Fi",
  "2018",
  "2017",
  "Action",
  "Drama",
  "The Best",
  "Movie Ever",
  "Comedy",
  "Romance"
];

export const movieListWithSlug = movieLists.map(name => ({
  name,
  slug: slugify(name)
}));

export const movieListWithImage = movieListWithSlug.map((list, i) => ({
  ...list,
  poster_path: movies[i].poster_path
}));

export const movieListsWithMovies = movieListWithSlug.reduce((acum, list) => {
  acum[list.slug] = movies;
  return acum;
}, {});
