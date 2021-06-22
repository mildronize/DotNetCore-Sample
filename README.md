# .NET Core 5 Samples

## Prefix
- `Mild.DesignPattern.**`: Design Pattern Series
- `Mild.EF.**`: Entity Framework
- `Mild.MVC.**`: ASP.NET Core MVC
- `Microsoft.Learn.**`: Microsoft docs & learn modules
- `Microsoft.**`: Sample Code from Microsoft example

## All Sample
- [Microsoft.Learn.SecureAspnetCoreIdentity](Microsoft.Learn.SecureAspnetCoreIdentity)
- [Microsoft.React.Authentication.Starter](Microsoft.React.Authentication.Starter)
- [Mild.DesignPattern.MementoPattern](Mild.DesignPattern.MementoPattern)
- [Mild.EF.RazorPage.Example.ContosoUniversity](Mild.EF.RazorPage.Example.ContosoUniversity)
- [Mild.MVC.Authentication.Minimal](Mild.MVC.Authentication.Minimal)
- [Mild.MVC.Authentication.Openiddict.OAuth2.AuthorizationCodeRefreshToken](Mild.MVC.Authentication.Openiddict.OAuth2.AuthorizationCodeRefreshToken)
- [Mild.MVC.Authentication.Openiddict.OAuth2.ClientCredentials](Mild.MVC.Authentication.Openiddict.OAuth2.ClientCredentials)
- [Mild.MVC.Authentication.Openiddict.React](Mild.MVC.Authentication.Openiddict.React)
- [Mild.MVC.Minimal](Mild.MVC.Minimal)
- [Mild.React.Starter](Mild.React.Starter)

---



## Microsoft.Learn.SecureAspnetCoreIdentity

This project will be followed the learn modules: [Secure an ASP.NET Core web app with the Identity framework](https://docs.microsoft.com/en-us/learn/modules/secure-aspnet-core-identity/)

This project was created from the [Code](https://github.com/MicrosoftDocs/mslearn-aspnet-core/tree/master/modules/secure-aspnet-core-identity)

### Project Structure 
```
├───start ## Starter template
└───final ## Final code from this tutorial 
```

Note: The original article was designed in Azure Cloud Shell. Some how I can't use it one the website. So, I modify the article for local development.

The original article provides PosgreSQL & SQL Server, this article will apply docker and PosgreSQL for local development.

## Lesson

1. [Introduction](#unit-1-introduction)
2. [Set up the environment](#unit-2-set-up-the-environment)
3. [Configure Identity support](#unit-3-configure-identity-support)
4. [Customize Identity](#unit-4-customize-identity)
5. [Configure multi-factor authentication](#unit-5-configure-multi-factor-authentication)
6. [Use claims with policy-based authorization](#unit-6-use-claims-with-policy-based-authorization)

## Unit 1: Introduction

An online dog toy retailer, named Contoso Pets, is creating an app for viewing and managing the product catalog. You're asked to secure the app.

This module explores using ASP.NET Core Identity to support authentication and authorization in an ASP.NET Core Razor Pages web app.

### Learning objectives

In this module, you will:

- Configure Identity support in an existing ASP.NET Core web app.
- Provide new user registration capabilities.
- Extend Identity UI components.
- Customize multi-factor login capabilities.
- Implement policy-based authorization using claims.
- Customize and extend the underlying Identity data store.


---



## Microsoft.React.Authentication.Starter

Setup .NET Core 5 with React
Using `react` template (`dotnet new reactredux -au Individual`) 

## Features
- useSPA
- Class components
- Openid Connect with Identity Server

Note: this project for educational purpose.


---



## Mild.DesignPattern.MementoPattern

Demonstrate Memento Pattern: It able to undo and redo a state of objects.


---



## Mild.EF.RazorPage.Example.ContosoUniversity

Following in Doc: [docs.microsoft.com - Razor Pages with Entity Framework Core in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/data/ef-rp/intro?view=aspnetcore-5.0&tabs=visual-studio-code)

All explanation are inside inline comment

## Features
- Razor Page
- SQLite


---



## Mild.MVC.Authentication.Minimal

## Features
- MVC
- Cookie Authentication (SSR) 
- Razor Page controlled by the Controller
- Session Management 

## Limitation
- No connect to any DB


---



## Mild.MVC.Authentication.Openiddict.OAuth2.AuthorizationCodeRefreshToken

- Enable the the [Client Credentials Flow](https://oauth.net/2/grant-types/client-credentials/), which is suitable for **machine-to-machine** applications.

- Enable the [Authorization Code Flow with PKCE](https://oauth.net/2/grant-types/authorization-code/) which is the recommended flow for Single Page Applications (SPA) and native/mobile applications.

- Enable the [Refresh Token](https://oauth.net/2/grant-types/refresh-token/)

## Features
- MVC
- Cookie Authentication (SSR) 
- Razor Page controlled by the Controller
- Session Management 
- Use `Openiddict` for OAuth2 

## Limitation
- No connect to any DB


---



## Mild.MVC.Authentication.Openiddict.OAuth2.ClientCredentials

Enable the the [Client Credentials Flow](https://oauth.net/2/grant-types/client-credentials/), which is suitable for **machine-to-machine** applications.

## Features
- MVC
- Cookie Authentication (SSR) 
- Razor Page controlled by the Controller
- Session Management 
- Use `Openiddict` for OAuth2 

## Limitation
- No connect to any DB


---



## Mild.MVC.Authentication.Openiddict.React


---



## Mild.MVC.Minimal

Just a basic MVC 


---



## Mild.React.Starter

Moved to [SukreepCode/Mild.ReactTS.Starter](https://github.com/SukreepCode/Mild.ReactTS.Starter)

Minimal setup .NET Core 5 with React TypeScript.
Using `reactredux` template (`dotnet new reactredux`), removed Redux. 
Refactor from a class component to functional component.

## Features
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