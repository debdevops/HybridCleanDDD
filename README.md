# HybridCleanDDD

## Overview

HybridCleanDDD is a sample project demonstrating a hybrid approach combining **Domain-Driven Design (DDD)** and **Clean Architecture** principles using **ASP.NET Core 8**. This project aims to serve as a reference for designing modular, testable, and scalable applications.

---

## Architecture

The architecture follows the Clean Architecture principles with a focus on Domain-Driven Design (DDD). The solution is divided into layers:

1. **Domain Layer**:
   - Contains the core business logic, domain models, and interfaces.
   - Independent of external frameworks or technologies.
   - Key components:
     - **Entities**: Core domain objects with behavior.
     - **Value Objects**: Immutable objects representing domain concepts.
     - **Aggregates**: Group of related entities treated as a single unit.
     - **Repositories (Interfaces)**: Contracts for data persistence.

2. **Application Layer**:
   - Responsible for application logic and use cases.
   - Key components:
     - **Services**: Business logic for use cases.
     - **DTOs**: Data contracts between layers.
     - **Interfaces**: Contracts for external services.

3. **Infrastructure Layer**:
   - Implements domain and application interfaces.
   - Handles database operations, external APIs, and third-party integrations.
   - Key components:
     - **Persistence**: Entity Framework Core (EF Core) implementation.
     - **Configurations**: Database and external dependency setup.

4. **WebAPI Layer**:
   - Exposes the application to the outside world through RESTful APIs.
   - Key components:
     - **Controllers**: Handle HTTP requests and responses.
     - **Dependency Injection**: Configure services and repositories.

5. **Test Layers**:
   - Unit and integration tests for all layers.

---
