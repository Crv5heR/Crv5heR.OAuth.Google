using Crv5heR.OAuth.Google.Models.Google;

namespace Crv5heR.OAuth.Google.Services.Foundations.Google
{
    public interface IGoogleService
    {
        ValueTask<GoogleAuthResponse> AuthenticateAsync(GoogleAuthRequest googleAuthRequest);
    }
}
