using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CustomValidation
{
    public class ValidateBase
    {
        public List<string> ValiationErrors { get; set; }
        public bool Validate()
        {
            ValiationErrors = new List<string>();

            var validateModelType = this.GetType();
            foreach (PropertyInfo customProperty in validateModelType.GetProperties())
            {
                foreach (Attribute customAttribute in customProperty.GetCustomAttributes(false))
                {
                    if (customAttribute is CustomValidation validation)
                    {
                        string propValue = customProperty.GetValue(this).ToString();
                        if (validation.MaxLength != 0)
                        {
                            if (validation.MaxLength < propValue.Length)
                                ValiationErrors.Add(string.Format("{0}:maxlength:{1}", customProperty.Name,
                                    validation.MaxLength));
                        }
                        if (validation.MinLength != 0)
                        {
                            if (validation.MinLength > propValue.Length)
                                ValiationErrors.Add(string.Format("{0}:minlength:{1}", customProperty.Name,
                                    validation.MinLength));
                        }
                    }
                }
            }
            return ValiationErrors.Count == 0;
        }
    }
}
