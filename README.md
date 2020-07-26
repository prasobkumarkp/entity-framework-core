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

### Full list of commands
ref : https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/?tabs=dotnet-core-cli

<br/>

## Sqlite

Open database
```sh
.open ./Data/SqlLite.db
```
Create table
```sh
create table tabler(firstname text not null, lastname text);
```
Insert into table
```sh
insert into tabler values("Prasob", "kumar");
```
Select data from table
```sh
select * from tabler;
```
Show tables
```sh
.tables
```
Quit database
```sh
.quit
```

### Full list of commands
ref : https://sqlite.org/cli.html