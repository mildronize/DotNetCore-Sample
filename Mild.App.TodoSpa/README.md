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
- [ ] Docker

# Ref
- Docker setup with postgres: https://www.dotnetthailand.com/storage/postgres/docker-compose-for-postgres
