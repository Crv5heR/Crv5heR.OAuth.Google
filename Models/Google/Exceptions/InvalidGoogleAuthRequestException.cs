using Xeptions;

namespace Crv5heR.OAuth.Google.Models.Google.Exceptions
{
    public class InvalidGoogleAuthRequestException : Xeption
    {
        public InvalidGoogleAuthRequestException()
            : base(message: $"Invalid Google Auth Request")
        { }
    }
}
