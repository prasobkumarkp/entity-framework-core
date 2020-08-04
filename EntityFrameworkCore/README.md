# entity-framework-core

## EnityFrameworkCore

Instruct EF Core to create a migration named InitialCreate:
```sh
dotnet ef migrations add InitialCreate
```

Create your database and create your schema from the migration
```sh
dotnet ef database update
```

Create a new migration
```sh
dotnet ef migrations add AddBlogCreatedTimestamp
```

Apply your migration
```sh
dotnet ef database update
```
Remove your last migration
```sh
dotnet ef database remove
```

### Full list of commands
ref : https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli

<br/>

## Sqlite

Open database
```sql
.open ./Data/SqlLite.db
```
Create table
```sql
create table tabler(firstname text not null, lastname text);
```
Insert into table
```sql
insert into tabler values("Prasob", "kumar");
```
Select data from table
```sql
select * from tabler;
```
Show tables
```sql
.tables
```
Quit database
```sql
.quit
```

### Full list of commands
ref : https://sqlite.org/cli.html