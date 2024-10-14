using System;

namespace Bank.Entities.Exceptions
{
     class DomainException : ApplicationException
    {
        public DomainException(string messege) : base(messege)
        {
        }
    }
}
