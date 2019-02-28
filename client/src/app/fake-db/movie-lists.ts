import { movies } from "./movies";

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

export const movieListWithImage = movieLists.map((name, i) => ({
  name,
  poster_path: movies[i].poster_path
}));

export const movieListsWithMovies = movieLists.reduce((acum, name) => {
  acum[name] = movies;
  return acum;
}, {});