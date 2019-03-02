export interface IMovie {
  id: number;
  title: string;
  posterPath: string;
  rating: number;
  releaseDate: string;
  moviesDbId: number;
  movieListId: number;
}

export interface ICreateMovie {
  title: string;
  posterPath: string;
  releaseDate: string;
  moviesDbId: number;
  movieListId: number;
}

export interface IUpdateMovie {
  rating: number;
}
