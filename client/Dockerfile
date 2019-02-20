FROM node:10.15.1-alpine

WORKDIR /client

# Copy package.json and package-lock.json
COPY package*.json ./

# Install
RUN npm set progress=false && npm install --production
RUN npm install -g @angular/cli@7.3.1

# Copy app soruce
COPY . .

# Build
RUN npm run build-prod