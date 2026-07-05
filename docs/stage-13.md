# Stage 13 — Namespaces

## Why we are doing this
Namespaces let you isolate resources in the same cluster. This is useful for dev, test, and production environments.

## Key concepts
- Namespace: virtual partition inside a Kubernetes cluster.
- Resources in one namespace are isolated from another unless explicitly shared.
- You can use labels and selectors to organize workloads.

## What was added
- A dev namespace
- A prod namespace

## Verify the result
Run:

```powershell
kubectl apply -f k8s/namespaces/dev-namespace.yaml
kubectl apply -f k8s/namespaces/prod-namespace.yaml
kubectl get namespace dev prod
```

You should see both namespaces listed in the cluster.
