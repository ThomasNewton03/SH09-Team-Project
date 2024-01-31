#!/bin/bash

UNITY_VERSION=2022.3.12f1
IMAGE=unityci/editor
IMAGE_VERSION=3
DOCKER_IMAGE=$IMAGE:$UNITY_VERSION-base-$IMAGE_VERSION

read -p "Enter your Unity username (email): " UNITY_USERNAME
read -s -p "Enter your Unity password: " UNITY_PASSWORD
echo

winpty docker run -it --rm \
  -e "UNITY_USERNAME=$UNITY_USERNAME" \
  -e "UNITY_PASSWORD=$UNITY_PASSWORD" \
  -e "UNITY_SERIAL=SC-QCQ3-45P6-9FY4-AJZW-QUF5" \
  -e "TEST_PLATFORM=linux" \
  -e "WORKDIR=/root/project" \
  -v "$(pwd):/root/project" \
  $DOCKER_IMAGE \
  bash

