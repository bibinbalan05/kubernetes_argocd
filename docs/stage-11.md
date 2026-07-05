# Stage 11 — Rolling updates and deployment strategies

## Why we are doing this
Kubernetes should update applications without taking them down. Rolling updates let you replace pods gradually while keeping the service available.

## Key concepts
- RollingUpdate strategy: updates pods gradually.
- maxUnavailable: how many pods can be unavailable during the rollout.
- maxSurge: how many extra pods can be created during the rollout.

## What was added
- Rolling update settings for the Product API deployment
- Rolling update settings for the Order API deployment

## Verify the result
Run:

```powershell
kubectl apply -f k8s/product/deployment-with-config.yaml
kubectl apply -f k8s/order/deployment.yaml
kubectl rollout status deployment/product-api
kubectl rollout status deployment/order-api
kubectl get pods
```

You should see the rollout complete and the pods remain available throughout the update.
