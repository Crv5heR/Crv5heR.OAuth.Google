using Crv5heR.OAuth.Google.Models.Google;
using Crv5heR.OAuth.Google.Models.Google.Exceptions;

namespace Crv5heR.OAuth.Google.Services.Foundations.Google
{
    public partial class GoogleService
    {
        private void ValidateGoogleAuthRequest(GoogleAuthRequest googleAuthRequest)
        {
            if (googleAuthRequest is null)
            {
                throw new InvalidGoogleAuthRequestException();
            }

            if (string.IsNullOrWhiteSpace(googleAuthRequest.Token))
            {
                throw new InvalidAuthTokenException();
            }
        }

        private void ValidateGoogleAuthResponse(GoogleAuthResponse googleAuthResponse)
        {
            if (googleAuthResponse is null)
            {
                throw new InvalidGoogleAuthResponseException();
            }
        }
    }
}
