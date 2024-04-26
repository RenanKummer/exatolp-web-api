# ExatoLP Web APIs

Web APIs for corpus linguistic research in Brazilian Portuguese.

## Draft Docs

1. How to create migration files from current EF Core state?

First, you need to install `dotnet-ef` tool. Then, run the following command on solution root directory:

```shell
dotnet ef migrations add "ShortDescription" -o Resources/Migrations -p src/Infrastructure -s src/WebApi
```

The migration `"ShortDescription"` is added as suffix to the file name, make sure it's compliant with your OS.

Tip: Use `PascalCase` to ensure a proper C# class name in the generated files.

2. How to apply migration files in the server?

In the server, clone the code repository and go to the solution directory. Then, run the following command:

```shell
dotnet ef database update -p src/Infrastructure -s src/WebApi --connection "Server=localhost;Port=5432;User Id=the-user-id;Password=the-password;Database=ufrgs-exatolp-web;"
```
