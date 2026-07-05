# Stage 4 — Create a local Kubernetes cluster

## Why we are doing this
Kubernetes runs your application inside a cluster. A cluster is a group of machines that work together to run your containers.

## Key concepts
- Cluster: the whole Kubernetes environment
- Node: a machine in the cluster
- Control plane: the brain of Kubernetes
- Worker node: the machine that actually runs your pods

## Why Kind is useful
Kind creates a local Kubernetes cluster using Docker containers. That makes it perfect for learning.

## What to do next
If Kind is installed, run:

```powershell
kind create cluster --name argok8s
```

If Kind is not installed, install it first and then create the cluster.

## Verify the cluster
Run:

```powershell
kubectl get nodes
```

You should see one or more nodes listed.
