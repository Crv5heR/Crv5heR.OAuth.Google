namespace Crv5heR.OAuth.Google.Brokers.Apis
{
    public interface IApiBroker
    {
        ValueTask<TContent> GetAsync<TContent>(string relativeUrl);
        ValueTask<TContent> PostAsync<TContent>(string relativeUrl, TContent content);
        ValueTask<TContent> PostAsync<TContent>(string relativeUrl);
        ValueTask<TResult> PostAsync<TContent, TResult>(string relativeUrl, TContent content);
        ValueTask<TResult> PutAsync<TContent, TResult>(string relativeUrl, TContent content);
        ValueTask<TContent> DeleteAsync<TContent>(string relativeUrl);
    }
}
