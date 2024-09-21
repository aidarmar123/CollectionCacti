using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;

namespace CollectionRareCacti.Service
{
    public static class ValidationClass
    {
        public static StringBuilder ValidationLine<T>(T data)
        {
            var error = new StringBuilder();
            var valContext = new ValidationContext(data);
            var valResult = new List<ValidationResult>();

            if (!Validator.TryValidateObject(data, valContext, valResult))
            {
                foreach (var item in valResult)
                {
                    error.AppendLine(item.ErrorMessage);
                }
            }
            return error;
        }
    }
}
