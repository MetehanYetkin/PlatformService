# PlatformService
 




## Problems
```bash
 "Denied: requested access to the resource is denied”
```
 when pushing the project to Docker Hub account For the problem, first of all, we need to check if there is a docker container currently running.
 ```sh
docker ps
```
We can see it from the console screen that comes with the command. After that
 ```sh
docker login -u "Dockerhub name" -p "Dockerhub password"
```
I checked that I am logged into my dockerhub account with the command .
 ```sh
docker image tag "myimage" "myimage":"tagname(ex.version1)"
```
I created my tag with, even if you don't create it, by default **latest**  will throw .
```sh
docker push <hub-user>/<repo-name>:<tag>
```
It was fixed when I pushed again with the method.
