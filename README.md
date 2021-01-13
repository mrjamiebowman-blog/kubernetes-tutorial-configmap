# Kubernetes Tutorial: ConfigMap in .NET
Kubernetes Tutorial: ConfigMap in .NET

## Docker Image

[https://hub.docker.com/repository/docker/mrjamiebowman/kubernetes-tutorial-configmap](https://hub.docker.com/repository/docker/mrjamiebowman/kubernetes-tutorial-configmap)

## Kubernetes
You can access the Kubernetes pod by using this command below.

To get a list of all resources created in the Kubernetes clusters under the `mrjamiebowman` namespace run this command.

`kubectl get all -n mrjamiebowman`

To get terminal access to the pod run this command. Be sure to put the correct pod name.

`kubectl exec --stdin --tty pod/kubernetes-tutorial-7c49dbddc5-xfwxn -- /bin/bash`