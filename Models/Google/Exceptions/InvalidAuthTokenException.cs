using Xeptions;

namespace Crv5heR.OAuth.Google.Models.Google.Exceptions
{
    public class InvalidAuthTokenException : Xeption
    {
        public InvalidAuthTokenException()
            : base(message: $"Invalid Bearer Token")
        {}
    }
}
