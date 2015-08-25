using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.ValidationMessaging
{
    public interface IValidationResult
    {
        /// <summary>
        /// list of validation messages includint errors, warnings and info
        /// </summary>
        List<IValidationMessage> ValidationMessageList { get;}
        
        /// <summary>
        /// bool that determines if all validation is successful
        /// </summary>
        bool IsValid { get; }

        void OverrideIsValid(bool isValid);

    }
}
