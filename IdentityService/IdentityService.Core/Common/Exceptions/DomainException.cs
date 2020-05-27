using System;

namespace IdentityService.Core.Common.Exceptions
{
    public class DomainException : Exception
    {
        public DomainException()

        {
        }

        public DomainException(string businessMessage) : base(businessMessage)
        {
        }

        public DomainException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
