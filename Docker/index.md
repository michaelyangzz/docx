# Useful Docker CLI Commands

## Docker Volume
List volumes:
```sh
docker volume ls
```
Create a volume:
```sh
docker volume create VOLUME_NAME
```
Attach a volume to a container:
```sh
docker run -v VOLUME_NAME:/path/in/container IMAGE
```

## Docker image details
View all image layers:
```sh
docker image history {image name} --no-trunc
```
## Docker build
Build:
```sh
docker build -t 'image name' .
```
the last dot(.) tells Docker where to find the Dockerfile.
what does the path mean in Dockerfile? it is related to path of Docker file?

These commands cover the most common tasks you'll perform with Docker. Happy containerizing!