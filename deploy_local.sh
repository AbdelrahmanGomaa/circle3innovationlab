#!/bin/bash

# 1. Publish the project
dotnet publish circle3innovationlab/circle3innovationlab.csproj -c Release -o publish

# 2. Add publish changes to Git
git add .
git commit -m "Auto-publish and deploy"
git push
