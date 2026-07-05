# Stage 10 — Health checks and scaling

## Why we are doing this
Kubernetes should not only run containers; it should also know when a pod is ready to serve traffic and when it should scale out under load.

## Key concepts
- Readiness probe: tells Kubernetes when a pod is ready to receive traffic.
- Liveness probe: tells Kubernetes when a pod should be restarted.
- Resource requests/limits: help Kubernetes make scheduling decisions.
- Horizontal Pod Autoscaler (HPA): scales deployments based on CPU usage.

## What was added
- Readiness and liveness probes for Product API and Order API
- CPU requests/limits in both deployments
- A Horizontal Pod Autoscaler for each deployment
- A local metrics-server setup for Kind so HPA can read CPU metrics

## Verify the result
Run:

```powershell
kubectl get pods
kubectl get hpa
kubectl describe hpa product-api
kubectl describe hpa order-api
kubectl top pods
```

You should see the deployments running, the HPAs reporting CPU usage, and the pods staying healthy.
