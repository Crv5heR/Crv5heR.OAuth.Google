using Crv5heR.OAuth.Google.Models.Google;
using Crv5heR.OAuth.Google.Models.Google.Exceptions;
using RESTFulSense.Exceptions;

namespace Crv5heR.OAuth.Google.Services.Foundations.Google
{
    public partial class GoogleService
    {
        private delegate ValueTask<GoogleAuthResponse> ReturningAuthResponseFunction();

        private async ValueTask<GoogleAuthResponse> TryCatch(
            ReturningAuthResponseFunction returningAuthResponseFunction)
        {
            try
            {
                return await returningAuthResponseFunction();
            }
            catch (InvalidAuthTokenException)
            {
                throw new InvalidAuthTokenException();
            }
            catch (InvalidGoogleAuthRequestException)
            {
                throw new InvalidGoogleAuthRequestException();
            }
            catch (HttpResponseException httpResponseException)
            {
                var FailedRequestException =
                    new FailedRequestException(httpResponseException);

                throw FailedRequestException;
            }
            catch (Exception exception)
            {
                var failedGoogleServiceException =
                    new FailedGoogleServiceException(exception);

                throw failedGoogleServiceException;
            }
        }
    }
}
