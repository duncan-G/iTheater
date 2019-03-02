export interface Movie {
  id: number;
  title: string;
  posterPath: string;
  releaseDate: string;
  moviesDbId?: number;
  movieListId?: number;
}
