# Stage 12 — ConfigMaps and Secrets

## Why we are doing this
Applications often need configuration values that should not be hardcoded in the image. Kubernetes provides ConfigMaps for non-sensitive data and Secrets for sensitive data.

## Key concepts
- ConfigMap: stores non-sensitive key/value configuration.
- Secret: stores sensitive key/value values.
- Environment variables can be injected from both ConfigMaps and Secrets.

## What was added
- An app ConfigMap with environment-style values
- An app Secret with example credentials

## Verify the result
Run:

```powershell
kubectl apply -f k8s/config/configmap.yaml
kubectl apply -f k8s/config/secret.yaml
kubectl get configmap app-config
kubectl get secret app-secret
```

You should see both resources created in the cluster.
