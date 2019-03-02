// This file can be replaced during build by using the `fileReplacements` array.
// `ng build --prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  production: false,
  hmr: true,
  defaultPosterUrl: '/assets/movie-poster-default.png',
  posterBaseUrl: 'http://image.tmdb.org/t/p/w300/',
  posterSmallBaseUrl: 'http://image.tmdb.org/t/p/w92/',
  backdropBaseUrl: 'http://image.tmdb.org/t/p/original/',
  serverUrl: 'https://localhost:5001/',
  movieBaseUrl: 'https://api.themoviedb.org/3/',
  moviePublicKey: '4828e7339a2fec105560e72dd6d5dd36',
};

/*
 * For easier debugging in development mode, you can import the following file
 * to ignore zone related error stack frames such as `zone.run`, `zoneDelegate.invokeTask`.
 *
 * This import should be commented out in production mode because it will have a negative impact
 * on performance if an error is thrown.
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.
