# Stage 7 — Deploy SQL Server with ConfigMaps and Secrets

## Why we are doing this
Applications need configuration and credentials. In Kubernetes, ConfigMaps store non-sensitive configuration, while Secrets store sensitive data such as passwords.

## Key concepts
- ConfigMap: stores environment values such as ports or mode settings
- Secret: stores sensitive values such as passwords
- Environment variables: a common way for apps to read configuration

## Why this matters
A pod should not hardcode secrets in the image. Kubernetes provides a safer way to inject them at runtime.

## Apply the database manifests
Run:

```powershell
kubectl apply -f k8s/database/configmap.yaml
kubectl apply -f k8s/database/secret.yaml
kubectl apply -f k8s/database/deployment.yaml
kubectl apply -f k8s/database/service.yaml
```

## Inspect the resources
Run:

```powershell
kubectl get configmap
kubectl get secret
kubectl get pods
kubectl get svc
```
