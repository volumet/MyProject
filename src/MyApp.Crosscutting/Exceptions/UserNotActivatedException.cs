using System.Security.Authentication;

namespace MyCNameSpace.Crosscutting.Exceptions
{
    public class UserNotActivatedException : AuthenticationException
    {
        public UserNotActivatedException(string message) : base(message)
        {
        }
    }
}
