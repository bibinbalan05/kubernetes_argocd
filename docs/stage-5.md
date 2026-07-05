# Stage 5 — Deploy the Product API

## Why we are doing this
A Kubernetes deployment tells Kubernetes how to run your application and how many copies to keep. This is the first step from a container image to a running service in the cluster.

## Key concepts
- Pod: the smallest deployable unit in Kubernetes
- ReplicaSet: ensures the desired number of pod copies exists
- Deployment: a higher-level controller that manages ReplicaSets and rolling updates

## What the YAML does
- Deployment creates a pod running the ProductApi image
- The selector tells Kubernetes which pods belong to this deployment
- The replicas field asks for one pod
- The containerPort field says the app listens on port 8080

## Apply the deployment
Run:

```powershell
kubectl apply -f k8s/product/deployment.yaml
kubectl apply -f k8s/product/service.yaml
```

## Check the pod
Run:

```powershell
kubectl get pods
kubectl get deployments
kubectl get services
```

## Why this matters
The deployment controller watches the cluster and tries to keep the requested number of pods running. If a pod dies, it creates another one.
