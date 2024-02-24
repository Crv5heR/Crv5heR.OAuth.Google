using Xeptions;

namespace Crv5heR.OAuth.Google.Models.Google.Exceptions
{
    public class FailedGoogleServiceException : Xeption
    {
        public FailedGoogleServiceException(Exception innerException)
            : base(message: "Failed Google Service error occurred", innerException) { }
    }
}
