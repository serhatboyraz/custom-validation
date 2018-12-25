using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation
{
    public class CustomerModel  : ValidateBase
    {
        [CustomValidation(MaxLength = 5,MinLength = 3)]
        public string CustomerCode { get; set; }
    }
}
