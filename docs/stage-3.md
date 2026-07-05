# Stage 3 — Run everything with Docker Compose

## Why we are doing this
Before Kubernetes, we use Docker Compose to run multiple containers together on one machine. It helps us understand the idea of service-to-service communication and container orchestration without the complexity of Kubernetes.

## What Docker Compose is
Docker Compose is a tool that lets us describe multiple containers in one YAML file and start them together.

## Why this is useful
- It is simpler than Kubernetes
- It helps us test the app locally before moving to Kubernetes
- It introduces the idea of multiple services working together

## What this compose file does
- Starts ProductApi on port 5100
- Starts OrderApi on port 5200
- Builds images from the Dockerfiles if they do not already exist

## Your next step
Run these commands:

```powershell
cd c:\Anjana\ArgoCD_Kubernetes_Project_Local
docker compose up --build
```

Then open:
- http://localhost:5100/health
- http://localhost:5200/health

To stop it later, run:

```powershell
docker compose down
```
