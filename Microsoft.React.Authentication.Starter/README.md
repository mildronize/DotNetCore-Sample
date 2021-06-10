# Microsoft.React.Authentication.Starter

Setup .NET Core 5 with React
Using `react` template (`dotnet new reactredux -au Individual`) 

# Features
- useSPA
- Redux
- Class components
- Openid Connect with Identity Server

Note: this project for educational purpose.

<!-- more -->
# Run

```sh
dotnet run
```

Open browser: https://localhost:5001/


Client_id: `Microsoft.React.Authentication.Starter`

https://localhost:5001/_configuration/Microsoft.React.Authentication.Starter

```json
{
    "authority": "https://localhost:5001",
    "client_id": "Microsoft.React.Authentication.Starter",
    "redirect_uri": "https://localhost:5001/authentication/login-callback",
    "post_logout_redirect_uri": "https://localhost:5001/authentication/logout-callback",
    "response_type": "code",
    "scope": "Microsoft.React.Authentication.StarterAPI openid profile"
}
```

# Mock Request 
`setupTests.js`

```json
{
    "authority": "https://localhost:5001",
    "client_id": "Microsoft.React.Authentication.Starter",
    "redirect_uri": "https://localhost:5001/authentication/login-callback",
    "post_logout_redirect_uri": "https://localhost:5001/authentication/logout-callback",
    "response_type": "id_token token",
    "scope": "Microsoft.React.Authentication.StarterAPI openid profile"
}
```