# Matrix EveM API

What's included:

- [.NET 7.0](https://dotnet.microsoft.com/download/dotnet/7.0)
- [Mapster](https://github.com/MapsterMapper/Mapster)
- [Swagger](https://swagger.io/)
- [Fluent Validation](https://fluentvalidation.net/)

## Table of Content

- [Quick Start](#quick-start)
    - [Prerequisites](#prerequisites)
    - [Development Environment Setup](#development-environment-setup)
    - [Build and run](#build-and-run-from-source)
    - [Database Migrations](#database-migrations)
- [License](#license)

## Quick Start

After setting up your local DEV environment, please follow the below sections to run the solution locally.

### Prerequisites

You'll need the following tools:

- [.NET SDK](https://dotnet.microsoft.com/download), version `>=7`
- [Visual Studio](https://visualstudio.microsoft.com/), version `>=2022` or [JetBrains Rider](https://jetbrains.com/rider/), version `>=2023`
- [MS SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads), version `>=2019`

### Development Environment Setup

First clone this repository locally.

- Install all of the the prerequisite tools mentioned under the [prerequisites](#prerequisites) section.

### Build and run from source

With Visual studio:
Open up the solutions using Visual studio.

- Restore solution `nuget` packages.
- Rebuild solution once.
- Run the solution.
- Local swagger URL [here](https://localhost:7150/swagger).

### Database Migrations

Following command will create database migration. Replace `MIGRATION_NAME` with your migration name

```bash
dotnet ef migrations add "MIGRATION_NAME" --project src/Matrix.EveM.Dal --startup-project src/Matrix.EveM.Api --output-dir Migrations
```

Following command will update the database with the created migration

```bash
dotnet ef database update --project src/Matrix.EveM.Dal --startup-project src/Matrix.EveM.Api
```

## License

Licensed under the [MIT](LICENSE) license.
