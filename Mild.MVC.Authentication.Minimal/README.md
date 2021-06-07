# Mild.MVC.Authentication.Minimal

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

Start the application, you should see a sign-in button on the home page:

![https://res.cloudinary.com/practicaldev/image/fetch/s--FwO4--n8--/c_limit%2Cf_auto%2Cfl_progressive%2Cq_auto%2Cw_880/https://dev-to-uploads.s3.amazonaws.com/i/35a01y8defub4u2ina7l.png](https://res.cloudinary.com/practicaldev/image/fetch/s--FwO4--n8--/c_limit%2Cf_auto%2Cfl_progressive%2Cq_auto%2Cw_880/https://dev-to-uploads.s3.amazonaws.com/i/35a01y8defub4u2ina7l.png)

When you click `Sign in` you should navigate to the login form:

![https://res.cloudinary.com/practicaldev/image/fetch/s--gABHALeq--/c_limit%2Cf_auto%2Cfl_progressive%2Cq_auto%2Cw_880/https://dev-to-uploads.s3.amazonaws.com/i/lghiwqsrfwwn7gqss16p.png](https://res.cloudinary.com/practicaldev/image/fetch/s--gABHALeq--/c_limit%2Cf_auto%2Cfl_progressive%2Cq_auto%2Cw_880/https://dev-to-uploads.s3.amazonaws.com/i/lghiwqsrfwwn7gqss16p.png)

To sign in, just fill in random credentials, everything but an empty value is fine.If everything works correctly you should be redirected to the home page which shows you are signed in:

![https://res.cloudinary.com/practicaldev/image/fetch/s--UldJaNLn--/c_limit%2Cf_auto%2Cfl_progressive%2Cq_auto%2Cw_880/https://dev-to-uploads.s3.amazonaws.com/i/yqzbu8i2m2dtu5brjcq9.png](https://res.cloudinary.com/practicaldev/image/fetch/s--UldJaNLn--/c_limit%2Cf_auto%2Cfl_progressive%2Cq_auto%2Cw_880/https://dev-to-uploads.s3.amazonaws.com/i/yqzbu8i2m2dtu5brjcq9.png)

# Ref
https://dev.to/robinvanderknaap/setting-up-an-authorization-server-with-openiddict-part-ii-create-aspnet-project-4949