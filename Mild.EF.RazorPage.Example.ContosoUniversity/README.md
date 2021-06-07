# Mild.EF.RazorPage.Example.ContosoUniversity

Following in Doc: [docs.microsoft.com - Razor Pages with Entity Framework Core in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio-code)

All explanation are inside inline comment

# Features
- Razor Page
- SQLite

<!-- more -->

![](screenshot.png)

# Code Checkpoint in tutorial 

Following in Doc: [docs.microsoft.com - Razor Pages with Entity Framework Core in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio-code)

1. [Tutorial 1 of 8](https://github.com/SukrepCode/DotNetCore.Templates/tree/b007ab26699f268b468e7a9cafd662cfcf626819/Mild.EF.RazorPage.Example.ContosoUniversity) - Get Started
    - [Performance considerations](https://github.com/SukrepCode/DotNetCore.Templates/tree/3da281ae48501f50f01d642c663d3a38bbc2ee04/Mild.EF.RazorPage.Example.ContosoUniversity) - We can set the maximum rows to display in MVC
    - [SQL Logging of Entity Framework Core](https://github.com/SukrepCode/DotNetCore.Templates/blob/f070b9e6ab5ab9c1b7c7461c3e09af92db2e5868/Mild.EF.RazorPage.Example.ContosoUniversity/appsettings.json#L7) - We can see the raw query in the log ([Read more](https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio-code#sql-logging-of-entity-framework-core))




# Run

```sh
dotnet run
```

Open browser: https://localhost:5001/

```
dotnet ef database update
```

# Command

```
dotnet add package Microsoft.EntityFrameworkCore.SQLite -v 5.0.0-*
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 5.0.0-*
dotnet add package Microsoft.EntityFrameworkCore.Design -v 5.0.0-*
dotnet add package Microsoft.EntityFrameworkCore.Tools -v 5.0.0-*
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design -v 5.0.0-*
dotnet add package Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore -v 5.0.0-*

dotnet tool install --global dotnet-aspnet-codegenerator
dotnet aspnet-codegenerator razorpage -m Student -dc Mild.EF.RazorPage.Example.ContosoUniversity.Data.SchoolContext -udl -outDir Pages/Students --referenceScriptLibraries -sqlite
```

The scaffolding process:

- Creates Razor pages in the `Pages/Students` folder:
    - Create.cshtml and Create.cshtml.cs
    - Delete.cshtml and Delete.cshtml.cs
    - Details.cshtml and Details.cshtml.cs
    - Edit.cshtml and Edit.cshtml.cs
    - Index.cshtml and Index.cshtml.cs
    - Creates Data/SchoolContext.cs.
- Adds the context to dependency injection in `Startup.cs`.
- Adds a database connection string to `appsettings.json`. (Then we can change to be shorter version `"SchoolContext": "Data Source=CU.db"`)