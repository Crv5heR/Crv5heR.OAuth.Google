using Xeptions;

namespace Crv5heR.OAuth.Google.Models.Google.Exceptions
{
    public class InvalidGoogleAuthResponseException : Xeption
    {
        public InvalidGoogleAuthResponseException()
            : base(message: $"Invalid Google Auth Response")
        { }
    }
}
