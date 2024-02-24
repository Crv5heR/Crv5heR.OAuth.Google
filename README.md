
# YAGOA

Yet another Google OAuth Library

YAGOA is a .NET Library that consumes the Google OAuth API to retrieve the authorized user data for the backend to process

You can use it to validate the user email and info when creating a new account or logging in.

of course you'll need to authenticate on the Frontend side to retrieve to Google Bearer Token

I suggest using [react-oauth](https://github.com/MomenSherif/react-oauth) by [MomenSherif](https://github.com/MomenSherif) on the frontend side.

# Usage
You can simply use this library by creating an instance of `GoogleService`
and call `AuthenticateAsync()`:

```csharp
GoogleService googleService = new GoogleService();

GoogleAuthRequest googleAuthRequest = new GoogleAuthRequest
{
    Token = "YOUR_GOOGLE_ACCESS_TOKEN"
};

GoogleAuthResponse googleAuthResponse =
    await googleService.AuthenticateAsync(googleAuthRequest);
```

`GoogleAuthResponse` will return the following data:
- Name
- GivenName (First Name)
- FamilyName (Last Name)
- Email
- Picture (Picture URL)
- HostedDomain (User's Organization Domain)
- Locale

# Expectations
- The `Token` property in `GoogleAuthRequest` is the Bearer Token that you get from the frontend
- The `GoogleAuthResponse` will contain the user's data if the token is valid

# Exceptions
|Exception|Reason|
|--- |--- |--- |
|FailedRequestException | Http Request Error|
|InvalidTokenException | Invalid Token |
|InvalidGoogleAuthRequestException | `GoogleAuthRequest` is null |
|FailedGoogleServiceException| Google Service Error |

# Packages that I used
- [RESTFULSense](https://github.com/hassanhabib/RESTFulSense) by [HassanHabib](https://github.com/hassanhabib)
- [Xeption](https://github.com/hassanhabib/Xeption) by [HassanHabib](https://github.com/hassanhabib)

# Why I Made This
The main reason Is to simplify my work process by reusing the same code every time for SSO Authentication

# Contributing
I welcome any sort of contribution, Please use [The-Standard](https://github.com/hassanhabib/The-Standard).

