using RESTFulSense.Clients;

namespace Crv5heR.OAuth.Google.Brokers.Apis
{
    public class ApiBroker : IApiBroker
    {
        private readonly IRESTFulApiFactoryClient apiClient;

        public ApiBroker(HttpClient httpClient) =>
           this.apiClient = new RESTFulApiFactoryClient(httpClient);

        public async ValueTask<TContent> GetAsync<TContent>(string relativeUrl) =>
          await this.apiClient.GetContentAsync<TContent>(relativeUrl);
    }
}
