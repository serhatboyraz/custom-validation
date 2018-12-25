using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new CustomerModel();
            x.CustomerCode = "1234";
            if (!x.Validate())
            {
                //x.ValiationErrors
            }

            Console.ReadKey();
        }
    }
}
