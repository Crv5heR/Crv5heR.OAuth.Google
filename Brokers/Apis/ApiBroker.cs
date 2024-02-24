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

        public async ValueTask<TContent> PostAsync<TContent>(string relativeUrl, TContent content) =>
            await this.apiClient.PostContentAsync(relativeUrl, content);

        public async ValueTask<TContent> PostAsync<TContent>(string relativeUrl) =>
            await this.apiClient.PostContentAsync<TContent>(relativeUrl, default);

        public async ValueTask<TResult> PostAsync<TContent, TResult>(string relativeUrl, TContent content) =>
            await this.apiClient.PostContentAsync<TContent, TResult>(relativeUrl, content);

        public async ValueTask<TResult> PutAsync<TContent, TResult>(string relativeUrl, TContent content) =>
            await this.apiClient.PutContentAsync<TContent, TResult>(relativeUrl, content);

        public async ValueTask<TContent> DeleteAsync<TContent>(string relativeUrl) =>
            await this.apiClient.DeleteContentAsync<TContent>(relativeUrl);
    }
}
