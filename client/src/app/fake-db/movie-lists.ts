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

export const moveListsWithMovies = movieLists.map(movie => ({
  name: movie,
  recentlyAdded: movies
}));
