# Stage 8 — Connect the Product API to SQL Server

## Why we are doing this
The Product API needs a database. In Kubernetes, services provide stable DNS names, so the API can connect to SQL Server using the service name instead of a pod IP.

## Key concepts
- Service DNS: Kubernetes gives each service a stable internal DNS name
- Service discovery: applications discover other services using names
- Environment variables: the API can read connection details from configuration

## Why this matters
If the SQL Server pod is recreated, the service name stays the same. That is much more reliable than using a changing IP address.

## What we will do next
We will update the Product API so it can read a connection string from the environment.

## Your next step
We will add configuration and then deploy an updated Product API image.
