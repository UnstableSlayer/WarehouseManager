using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace WarehouseManager.Common.Exceptions
{
    public class CommandValidationException : DomainException
    {
        public IEnumerable<CommandValidationError> Errors { get; }

        public CommandValidationException(CommandValidationError error) : base(error?.ErrorMessage)
        {
            Errors = new List<CommandValidationError> { error };
        }

        public CommandValidationException(IEnumerable<CommandValidationError> error) : base(error?.Where(x => x != null).Select(x => x.ErrorMessage))
        {
            Errors = error;
        }
    }
}
