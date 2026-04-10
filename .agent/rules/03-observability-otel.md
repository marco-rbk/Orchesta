---
trigger: always_on
---

# Observability & OpenTelemetry Rules

- Every microservice MUST reference the central `ServiceDefaults` project.
- Do not add manual OpenTelemetry or logging bootstrap code (`AddOpenTelemetry()`) directly within the business microservices. Rely entirely on the `ServiceDefaults` extension methods.
- Use `System.Diagnostics.Metrics.Meter` for custom metrics. Prefix meter names with the bounded context (e.g., `Catalog.Metrics`).
- Use structured logging exclusively (e.g., `logger.LogInformation("Processing order {OrderId}", order.Id)`). Do not use string interpolation (`$""`) inside logging statements.
- Ensure all HTTP clients and database connections use the standardized resilience pipelines provided by `Microsoft.Extensions.Http.Resilience` configured in `ServiceDefaults`.