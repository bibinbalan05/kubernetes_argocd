# Stage 1 — Create the .NET solution

## Why we are doing this
We start with a simple application so that the Kubernetes concepts later have a real workload to run. A tiny microservice-based app is easier to understand than a large production system.

## What we built
- A solution named ArgoK8sLearning
- Two ASP.NET Core APIs:
  - ProductApi
  - OrderApi
- Each API exposes a simple health endpoint and a sample resource endpoint

## How to verify locally
Run the following commands:

```powershell
dotnet build ArgoK8sLearning.sln
dotnet run --project src/ProductApi/ProductApi.csproj
dotnet run --project src/OrderApi/OrderApi.csproj
```

Open these URLs in your browser:
- http://localhost:5000/health
- http://localhost:5001/health

If the ports differ, check the console output from each process.

## What this teaches you
This stage introduces the idea of services as independent units. In Kubernetes, each service will later become a deployment and a pod.

## Your next step
When you have verified the two APIs run locally, tell me and I will move to Stage 2.
