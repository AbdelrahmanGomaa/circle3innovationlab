#!/bin/bash

cd /var/www/projects/circle3lab

# Pull latest changes from GitHub
git pull origin main

# Restart containers
docker-compose down
docker-compose up -d --build
