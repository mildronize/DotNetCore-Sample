# Mild.EF.RazorPage.Example.ContosoUniversity

Following in Doc: [docs.microsoft.com - Razor Pages with Entity Framework Core in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio-code)


# Features
- MVC
- Cookie Authentication (SSR) 
- Razor Page controlled by the Controller
- Session Management 

# Limitation
- No connect to any DB

<!-- more -->

# Run

```sh
dotnet run
```

Open browser: https://localhost:5001/

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