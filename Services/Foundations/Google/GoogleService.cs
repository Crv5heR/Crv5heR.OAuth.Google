using System.Net.Http.Headers;
using Crv5heR.OAuth.Google.Brokers.Apis;
using Crv5heR.OAuth.Google.Models.Google;

namespace Crv5heR.OAuth.Google.Services.Foundations.Google
{
    public partial class GoogleService : IGoogleService
    {
        private readonly IApiBroker apiBroker;
        private readonly HttpClient httpClient;

        private const string GoogleAuthUrl = "https://www.googleapis.com";

        public GoogleService()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri(uriString: GoogleAuthUrl);

            this.apiBroker = new ApiBroker(httpClient: httpClient);
        }

        public async ValueTask<GoogleAuthResponse> AuthenticateAsync(
            GoogleAuthRequest googleAuthRequest) =>
            await TryCatch(async () =>
            {
                ValidateGoogleAuthRequest(googleAuthRequest);

                httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue(
                        scheme: "Bearer",
                        parameter: googleAuthRequest.Token);

                GoogleAuthResponse googleAuthResponse =
                    await apiBroker.GetAsync<GoogleAuthResponse>(
                        relativeUrl: "/oauth2/v3/userinfo");

                ValidateGoogleAuthResponse(googleAuthResponse);

                return googleAuthResponse;
            });
    }
}
