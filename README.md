# iTheater

Create movie lists and add movies to those lists.

![alt text](https://raw.githubusercontent.com/duncan-G/iTheater/master/docs/images/landing.PNG)

http://ec2-52-8-62-56.us-west-1.compute.amazonaws.com/

## Dependencies
- .NET core
- Angular 7
- MySQL 8
- Docker
- Nginx
- MovieDB API

##  Local Installation
- Clone Repo
- Setup environment variables in `./server/appsettings.json`
- `cd ./server` then `dotnet restore`, `dotnet watch run`
- Setup environment variabls in `./client/src/environment`
- `cd ./client`
  - `npm run start-hmr` to use hot module reloading (or)
  - `ng start` 
  
 ## Deployment
 - Create`.env` file in root directory. Similar to `.env.deploy`.
 - build image `/bin/bash deploy.sh` (may have bugs)
 - `cat docker-compose.yml | envsubst | docker-compose -f - build` to run
