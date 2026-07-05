# Stage 2 — Containerize each service with Docker

## Why we are doing this
Kubernetes does not run source code directly. It runs containers. A container is a packaged, isolated unit that includes your application and its runtime.

## Key concepts
- Dockerfile: a recipe for building an image
- Image: a read-only template used to create containers
- Container: a running instance of an image

## What the Dockerfiles do
Each Dockerfile has two stages:
1. Build stage: compiles the .NET app
2. Runtime stage: runs the compiled app in a lightweight container

## Why this is useful
A container gives you consistency. The same app can run on your laptop, a CI server, or a Kubernetes cluster.

## Your next step
Run these commands:

```powershell
cd c:\Anjana\ArgoCD_Kubernetes_Project_Local
docker build -f src/ProductApi/Dockerfile -t productapi:local .
docker build -f src/OrderApi/Dockerfile -t orderapi:local .
```

If those commands succeed, we will move to Docker Compose in the next stage.
