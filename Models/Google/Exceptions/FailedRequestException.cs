using Xeptions;

namespace Crv5heR.OAuth.Google.Models.Google.Exceptions
{
    public class FailedRequestException : Xeption
    {
        public FailedRequestException(Exception innerException)
            : base(message: "Http Request to Google failed", innerException) { }
    }
}
