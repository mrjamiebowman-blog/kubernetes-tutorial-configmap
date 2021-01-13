docker rm -f kubernetestutorial
docker run -d -p 8080:80 -v $pwd\kubernetestutorial\Settings\:/app/Settings --name kubernetestutorial mrjamiebowman/kubernetes-tutorial-configmap
docker exec -it kubernetestutorial /bin/bash