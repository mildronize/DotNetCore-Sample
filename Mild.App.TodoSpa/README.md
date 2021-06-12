# Mild.App.TodoSpa

Todo App

# Features
- useSPA
- TypeScript


<!-- more -->
# Run

```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
dotnet run
```

Open browser: https://localhost:5001/

```bash 
docker-compose up
# To remove a container with its volumes.
docker-compose down --volumes
```

# Use this project

```sh
git clone https://github.com/SukreepCode/DotNetCore.Templates.git && cd DotNetCore.Templates && git sparse-checkout set Mild.App.TodoSpa
```

Then replace `Mild.App.TodoSpa` to your project name

# Todo

- [ ] Testing
- [X] Docker

# Ref
- Docker setup with postgres: https://www.dotnetthailand.com/storage/postgres/docker-compose-for-postgres
- [ASP.NET Core 3.1 - Boilerplate API with Email Sign Up, Verification, Authentication & Forgot Password](https://jasonwatmore.com/post/2020/07/06/aspnet-core-3-boilerplate-api-with-email-sign-up-verification-authentication-forgot-password)
- [JWT Auth in ASP.NET Core](https://codeburst.io/jwt-auth-in-asp-net-core-148fb72bed03)
