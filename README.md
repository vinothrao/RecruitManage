Recruit mage service web application This is sample project that includes the following features :
•	Service-Repository architecture with Facade pattern
•	webapi with Angular as front end
•	Docker container support


References: 
•	https://www.udemy.com/docker-and-kubernetes-the-complete-guide
•	https://medium.com/devopslinks/minikube-installation-on-windows-10-9908d17cfad9

For minikube in local follow the above minikube installation guid and use the following command:

minikube start --vm-driver=”hyperv” --hyperv-virtual-switch="Default Switch"

Default Switch Name can be take from Opening Hyper-V Manage -> Action - >Virtaul Switch Manager
Or Create you own switch by following https://docs.microsoft.com/en-us/windows-server/virtualization/hyper-v/get-started/create-a-virtual-switch-for-hyper-v-virtual-machines
