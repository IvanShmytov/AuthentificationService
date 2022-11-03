using System;

namespace AuthentificationService
{
    public class CustomException : Exception
    {
        public CustomException(string message) : base(message)
        {
        }
    }
}
