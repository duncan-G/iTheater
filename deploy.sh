#!/bin/bash
set -a
source ./.env
# Substitute env variables in nginx template
envsubst '$$NGINX_HOST' < ./nginx/template.conf > ./nginx/default.conf
# Substitute env variables in docker-compose.yml and build
cat docker-compose.yml | envsubst | docker-compose -f - build