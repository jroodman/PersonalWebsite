# PersonalWebsite

My peronsal website, hosted at www.jasonroodman.com

## Getting Started

These instructions can be used to get a copy of the docker image
to deploy

1. Install Docker: `curl -sSL https://get.docker.com | sh`

2. Download image: `docker pull jroodman/personalwebsite`
	a. Confirm image is downloaded with `docker images`

3. Run the image: `docker run -i -t jroodman/persoanlwebsite:latest /bin/bash`

## Build Image

These instructions can be used to build and publish an updated docker image

1. From the project root directory run `docker-compose push jroodman/personalwebsite`

## Troubleshooting Docker

1. Attempt `docker ps`

If error is reported, run `docker-machine env default` and copy the listed command into command prompt

2. If docker container has not been started

Run `docker-machine start default`
