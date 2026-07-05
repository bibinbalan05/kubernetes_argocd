# Stage 14 — GitOps and Argo CD

## Why we are doing this
GitOps uses Git as the single source of truth for cluster state. Argo CD watches Git repositories and applies changes automatically.

## Key concepts
- GitOps: declarative infrastructure and application delivery from Git.
- Argo CD: a GitOps controller that syncs cluster state from Git.
- Application resource: points Argo CD at a Git repo and a target cluster namespace.

## What was added
- An Argo CD namespace and admin secret manifest
- A sample Argo CD Application resource

## Verify the result
Run:

```powershell
kubectl apply -f argocd/install.yaml
kubectl apply -f argocd/app.yaml
kubectl get namespace argocd
kubectl get application -n argocd
```

You should see the Argo CD namespace and application resource created.
