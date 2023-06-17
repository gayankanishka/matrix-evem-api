# Matrix EveM API

## Database Migrations

### Following command will create database migration. Replace `MIGRATION_NAME` with your migration name

```bash
dotnet ef migrations add "MIGRATION_NAME" --project src/Matrix.EveM.Dal --startup-project src/Matrix.EveM.Api --output-dir Migrations
```

### Following command will update the database with the created migration

```bash
dotnet ef database update --project src/Matrix.EveM.Dal --startup-project src/Matrix.EveM.Api
```