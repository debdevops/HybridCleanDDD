# HybridCleanDDD - ASP.NET Core 8 Clean Architecture with DDD

This project demonstrates an example implementation of Clean Architecture and Domain-Driven Design (DDD) principles using ASP.NET Core 8. It follows best practices for building scalable and maintainable applications, focusing on separation of concerns, testability, and domain-driven design patterns.


## Introduction

This is a sample project to demonstrate how to use Clean Architecture and DDD in an ASP.NET Core 8 application. It includes:
- **Domain Layer**: Contains the business logic and domain entities.
- **Application Layer**: Handles use cases, application logic, and services.
- **Infrastructure Layer**: Implements persistence and external service integrations.
- **Web API Layer**: Exposes the API endpoints.

The goal is to maintain separation of concerns while following best practices in software architecture.

## Features

- Domain-Driven Design (DDD) principles
- Clean Architecture pattern
- ASP.NET Core 8 API
- Dependency Injection
- Entity Framework Core for database interactions
- Async repository pattern
- Unit testing support

## Project Structure

The project is organized into multiple layers to follow the Clean Architecture principles:

## Run
dotnet build

dotnet run --project src/HybridCleanDDD.WebAPI