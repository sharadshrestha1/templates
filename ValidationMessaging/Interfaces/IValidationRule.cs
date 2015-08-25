using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Template.ValidationMessaging
{
    public interface IValidationRule
    {
        /// <summary>
        /// Override bool. If true, validation method is not performed.
        /// </summary>
        bool IsOverriden { get; set; }

        /// <summary>
        /// Result after validation
        /// </summary>
        IValidationResult RuleValidationResult { get; }

        /// <summary>
        /// Method that validates the rule
        /// </summary>
        /// <returns>Result after validation</returns>
        IValidationResult Validate();
    }
               
}
