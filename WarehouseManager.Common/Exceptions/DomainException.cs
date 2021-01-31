using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseManager.Common.Exceptions
{
    public class DomainException : Exception
    {
        public IEnumerable<string> Messages { get; }

        public DomainException(string message):base(message)
        {
            Messages = new List<string> { message };
        }
        
        public DomainException(IEnumerable<string> message):base(string.Join(", ", message))
        {
            Messages = message;
        }
    }
}
