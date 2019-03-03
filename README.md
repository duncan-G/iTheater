# iTheater

Create movie lists and movies to those lists.

http://52.8.62.56/

## Dependencies
- .NET core
- Angular 7
- MySQL 8
- Docker
- Nginx
- MovieDB API

##  Local Installation
- Clone Repo
- Setup environment variables in `./server/appsettings.json'
- `cd ./server` then `donet watch run`
- Setup environment variabls in `./client/src/environment`
- `cd ./client`
  - `npm run start-hmr` to use hot module reloading (or)
  - `ng start` 
  
 ## Deployment
 - build image `/bin/bash deploy.sh` (may have bugs)
 - `cat docker-compose.yml | envsubst | docker-compose -f - build` to run
