# Stage 9 — Deploy the Order API

## Why we are doing this
The Order API should not rely on a pod IP for communication. In Kubernetes, it can call ProductApi by using the service name product-api-service.

## Key concept
Kubernetes provides internal DNS for services. A service named product-api-service is reachable as product-api-service inside the cluster.

## Why this matters
This is the same pattern you will use in real microservice systems. Services discover each other by name, not by IP address.

## Apply the Order API manifests
Run:

```powershell
kubectl apply -f k8s/order/deployment.yaml
kubectl apply -f k8s/order/service.yaml
```

## Verify the result
Run:

```powershell
kubectl get pods
kubectl get svc
kubectl port-forward service/order-api-service 18081:80
```

Then open:

```text
http://127.0.0.1:18081/orders
```
