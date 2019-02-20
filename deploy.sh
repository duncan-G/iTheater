#!/bin/bash
set -a
source .env
envsubst '$$NGINX_HOST' < ./nginx/template.conf > ./nginx/default.conf
cat docker-compose.yml | envsubst | docker-compose -f - build