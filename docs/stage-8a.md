# Stage 8 — Connect the Product API to SQL Server

## Why we are doing this
Kubernetes Services give stable internal DNS names. The Product API can use the SQL Server service name instead of a changing pod IP.

## Key concept
A Service named sql-server-service inside the cluster can be reached as sql-server-service.

## Why this is useful
If the SQL Server pod is replaced, the service name does not change, so the API configuration stays stable.

## Apply the updated deployment
Run:

```powershell
kubectl apply -f k8s/product/deployment-with-config.yaml
```

## Verify the API config endpoint
Run:

```powershell
kubectl get pods
kubectl port-forward service/product-api-service 8080:80
```

Then open:

```text
http://127.0.0.1:8080/config
```
