namespace Crv5heR.OAuth.Google.Brokers.Apis
{
    public interface IApiBroker
    {
        ValueTask<TContent> GetAsync<TContent>(string relativeUrl);
    }
}
