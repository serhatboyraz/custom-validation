using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation
{
    [AttributeUsage(AttributeTargets.Property)]
    public class CustomValidation : Attribute
    {
        public int MaxLength { get; set; }
        public int MinLength { get; set; }
    }
}
