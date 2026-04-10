---
trigger: always_on
---

# Architecture Core Rules

- Use the .NET 10 SDK exclusively for all projects.
- Always use .NET Aspire (`AppHost` project) for local orchestration, service discovery, and configuration of dependencies.
- Implement microservices using Vertical Slice Architecture. Organize code by feature, not by technical layer.
- Use asynchronous communication (e.g., RabbitMQ or Kafka) for state changes and cross-domain events.
- Use gRPC or standard HTTP clients via `.NET Aspire Service Discovery` for direct, synchronous inter-service communication.
- Do not create monolithic shared libraries for business logic; share only pure infrastructure contracts if strictly necessary.