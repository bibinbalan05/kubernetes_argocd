# Stage 6 — Expose the API with a Service

## Why we are doing this
Pods are temporary. A pod can be deleted and recreated, and its IP address can change. Kubernetes Services give your application a stable network identity.

## Key concepts
- Service: gives stable access to a set of pods
- ClusterIP: only reachable from inside the cluster
- NodePort: exposes the service on each node's IP
- LoadBalancer: exposes the service through a cloud or external load balancer

## When to use each
- ClusterIP: internal communication between services
- NodePort: simple local or development exposure
- LoadBalancer: production-style external access in supported environments

## What we already have
We already created a ClusterIP service for the Product API.

## Why this matters
In Kubernetes, services are how one application finds another. For example, OrderApi will later call ProductApi using the service name rather than a pod IP.

## Your next step
Run:

```powershell
kubectl get svc
kubectl describe svc product-api-service
```

Then we will introduce a NodePort example to understand the difference.
