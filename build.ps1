docker build -f "kubernetestutorial\Dockerfile" `
    --force-rm -t mrjamiebowman/kubernetes-tutorial-configmap `
    --label "com.microsoft.created-by=visual-studio" `
    --label "com.microsoft.visual-studio.project-name=KubernetesTutorial" `
    "c:\mrjamiebowman\kubernetes-tutorial-configmap\kubernetestutorial"
