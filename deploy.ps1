kubectl create namespace mrjamiebowman

kubectl apply -f k8s/configmap.yaml
kubectl apply -f k8s/deployment.yaml
kubectl apply -f k8s/service.yaml

kubectl get all -n mrjamiebowman