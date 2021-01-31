using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseManager.Common.Exceptions
{
    public class CommandValidationError
    {
        public string PropertyName { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
