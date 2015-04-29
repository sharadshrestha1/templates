using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.ValidationMessaging
{
    public interface IValidator<T>
    {
        /// <summary>
        /// Performs validate method of all ValidationRules
        /// </summary>
        /// <param name="obj">object against which validation is performed</param>
        /// <returns>Validation Result</returns>
        IValidationResult Validate(T obj);

        /// <summary>
        /// overload. Performs validate method of all ValidationRules
        /// </summary>
        /// <param name="obj">object against which validation is performed</param>
        /// <param name="suppressWarnings">bool that suppresses warnings</param>
        /// <returns>Validation Result</returns>
        IValidationResult Validate(T obj, bool suppressWarnings);

        /// <summary>
        /// Validation Rule List 
        /// </summary>
        List<IValidationRule> ValidationRuleList { get; set; }

        /// <summary>
        /// Add IValidationRule to ValidationRuleList
        /// </summary>
        /// <param name="ValidationRule">IValidationRule to Aggregate</param>
        void AggregateValidationRule(IValidationRule ValidationRule);


        IValidationResult ValidationResult { get; set; }

        void AggregateValidationResult(IValidationResult validationResult);
    }
}
