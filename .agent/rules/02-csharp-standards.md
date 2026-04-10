---
trigger: always_on
---

# C# Coding Standards

- Use Minimal APIs (`app.MapGet`, `app.MapPost`) exclusively. Do not create or use MVC Controller classes (`ControllerBase`).
- Enforce `<Nullable>enable</Nullable>` and `<TreatWarningsAsErrors>true</TreatWarningsAsErrors>` in all `.csproj` files.
- Use modern C# 12+ features: default to Primary Constructors for dependency injection and use Collection Expressions (`[]`).
- Always pass `CancellationToken` to all asynchronous methods and database calls.
- Use `Records` for DTOs, Commands, and Queries to ensure immutability.
- Avoid throwing custom exceptions for control flow; use the Result pattern (e.g., returning success/failure states) for business logic validations.