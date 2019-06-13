#FairWarning : It's an experimental project. So still more architectural changes and implementation are under process.Right now concentrating on Dockerizing and up with Kubernetes so that it will act as good example.

Recruit mage service web application This is sample project that includes the following features :
•	Service-Repository architecture with Facade pattern
•	webapi with Angular as front end
•	Docker container support
•	Kubernetes 


References: 
•	https://www.udemy.com/docker-and-kubernetes-the-complete-guide
•	https://medium.com/devopslinks/minikube-installation-on-windows-10-9908d17cfad9

For minikube in local follow the above minikube installation guid and use the following command:

minikube start --vm-driver=”hyperv” --hyperv-virtual-switch="Default Switch"

Default Switch Name can be take from Opening Hyper-V Manage -> Action - >Virtaul Switch Manager
Or Create you own switch by following https://docs.microsoft.com/en-us/windows-server/virtualization/hyper-v/get-started/create-a-virtual-switch-for-hyper-v-virtual-machines

Docker build Command :

docker build -f RecruitManage\Dockerfile .
 Note : Use -t to tag a name for the built image (docker build -f RecruitManage\Dockerfile -t {name} .
 
 Docker Compose Command:
docker-compose up --build

This compose build will do the following:

1. Build 2 images one for client and another for web api.
2. Set up an Nginx proxy to route the requests between api/client calls.

Warning : Docker compose networking wont work for JS frameworks such as (Angular,React,Vue) to connect to the back end server. This is due to the fact the JS request are happening via browser ajax request which is outside of docker.Hence back end won't be available. So use nginx proxy to route the requests.
 
 
 Important :
 Make sure you ignore the file which is in .dockerignore
