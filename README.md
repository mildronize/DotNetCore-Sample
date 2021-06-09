# .NET Core 5 Templates

- [Mild.DesignPattern.MementoPattern](https://github.com/SukrepCode/DotNetCore.Templates/tree/main/Mild.DesignPattern.MementoPattern)
- [Mild.EF.RazorPage.Example.ContosoUniversity](https://github.com/SukrepCode/DotNetCore.Templates/tree/main/Mild.EF.RazorPage.Example.ContosoUniversity)
- [Mild.MVC.Authentication.Minimal](https://github.com/SukrepCode/DotNetCore.Templates/tree/main/Mild.MVC.Authentication.Minimal)
- [Mild.MVC.Authentication.Openiddict.OAuth2.AuthorizationCodeRefreshToken](https://github.com/SukrepCode/DotNetCore.Templates/tree/main/Mild.MVC.Authentication.Openiddict.OAuth2.AuthorizationCodeRefreshToken)
- [Mild.MVC.Authentication.Openiddict.OAuth2.ClientCredentials](https://github.com/SukrepCode/DotNetCore.Templates/tree/main/Mild.MVC.Authentication.Openiddict.OAuth2.ClientCredentials)
- [Mild.MVC.Authentication.Openiddict.React](https://github.com/SukrepCode/DotNetCore.Templates/tree/main/Mild.MVC.Authentication.Openiddict.React)
- [Mild.MVC.Minimal](https://github.com/SukrepCode/DotNetCore.Templates/tree/main/Mild.MVC.Minimal)
- [Mild.React.Starter](https://github.com/SukrepCode/DotNetCore.Templates/tree/main/Mild.React.Starter)


---



`Mild.DesignPattern.MementoPattern`
# Mild.DesignPattern.MementoPattern

Demonstrate Memento Pattern: It able to undo and redo a state of objects.



---



`Mild.EF.RazorPage.Example.ContosoUniversity`
# Mild.EF.RazorPage.Example.ContosoUniversity

Following in Doc: [docs.microsoft.com - Razor Pages with Entity Framework Core in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio-code)

All explanation are inside inline comment

# Features
- Razor Page
- SQLite



---



`Mild.MVC.Authentication.Minimal`
# Mild.MVC.Authentication.Minimal

# Features
- MVC
- Cookie Authentication (SSR) 
- Razor Page controlled by the Controller
- Session Management 

# Limitation
- No connect to any DB



---



`Mild.MVC.Authentication.Openiddict.OAuth2.AuthorizationCodeRefreshToken`
# Mild.MVC.Authentication.Openiddict.OAuth2.AuthorizationCodeRefreshToken

- Enable the the [Client Credentials Flow](https://oauth.net/2/grant-types/client-credentials/), which is suitable for **machine-to-machine** applications.

- Enable the [Authorization Code Flow with PKCE](https://oauth.net/2/grant-types/authorization-code/) which is the recommended flow for Single Page Applications (SPA) and native/mobile applications.

- Enable the [Refresh Token](https://oauth.net/2/grant-types/refresh-token/)

# Features
- MVC
- Cookie Authentication (SSR) 
- Razor Page controlled by the Controller
- Session Management 
- Use `Openiddict` for OAuth2 

# Limitation
- No connect to any DB



---



`Mild.MVC.Authentication.Openiddict.OAuth2.ClientCredentials`
# Mild.MVC.Authentication.Openiddict.OAuth2.ClientCredentials

Enable the the [Client Credentials Flow](https://oauth.net/2/grant-types/client-credentials/), which is suitable for **machine-to-machine** applications.

# Features
- MVC
- Cookie Authentication (SSR) 
- Razor Page controlled by the Controller
- Session Management 
- Use `Openiddict` for OAuth2 

# Limitation
- No connect to any DB



---



`Mild.MVC.Authentication.Openiddict.React`
# Mild.MVC.Authentication.Openiddict.React



---



`Mild.MVC.Minimal`
# Mild.MVC.Minimal

Just a basic MVC 



---



`Mild.React.Starter`
# Mild.React.Starter

Minimal setup .NET Core 5 with React TypeScript.
Using `reactredux` template (`dotnet new reactredux`), removed Redux. 
Refactor from a class component to functional component.

# Features
- useSPA
- TypeScript
- No Redux
- Functional components



---

## For building this file

```
node merge-md.js
```

## Other series

- [React App Collections](https://github.com/mildronize/react-apps)