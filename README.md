# iTheater

Create movie lists and add movies to those lists.

![alt text](https://raw.githubusercontent.com/duncan-G/iTheater/master/docs/images/landing.PNG)

http://ec2-52-8-62-56.us-west-1.compute.amazonaws.com/

## Dependencies
- .NET core 2.2
- Angular 7
- MySQL 8
- Docker
- Docker-compose
- Nginx
- MoviesDB API

##  Local Installation
- Clone Repo
- Setup environment variables in `./server/appsettings.json`
- `cd ./server` then `dotnet restore`, `dotnet watch run`
- Setup environment variabls in `./client/src/environment`
- `cd ./client`
  - `npm install`
  - `npm run start-hmr` to use hot module reloading (or)
  - `ng start` 
  
 ## Deployment
 - Build client `npm run build-prod`
 - Create`.env` file in root directory. Similar to `.env.deploy`.
 - Build docker image `/bin/bash deploy.sh` (may have bugs)
 - `cat docker-compose.yml | envsubst | docker-compose -f - up` to run

## Application views
**Login**
![alt text](https://raw.githubusercontent.com/duncan-G/iTheater/master/docs/images/login.PNG)

**Movie Lists**
![alt text](https://raw.githubusercontent.com/duncan-G/iTheater/master/docs/images/movielists.PNG)

**Movie List**
![alt text](https://raw.githubusercontent.com/duncan-G/iTheater/master/docs/images/movies.PNG)

**Add Movie**
![alt text](https://raw.githubusercontent.com/duncan-G/iTheater/master/docs/images/add_movie.PNG)

**Movie**
![alt text](https://raw.githubusercontent.com/duncan-G/iTheater/master/docs/images/watch_trailer.PNG)
