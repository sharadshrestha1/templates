using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface;


using Template.ValidationMessaging.ValidationMessage;
using Template.Business.Interface.Domain;

namespace Template.ValidationMessaging
{
    public class EmailValidator : MyValidator, IValidator<IEmail>
    {
        #region IValidator<IEmail> Members

        public IValidationResult Validate(IEmail obj)
        {
            return Validate(obj, false);
        }

        public IValidationResult Validate(IEmail obj, bool suppressWarnings)
        {
            //First check for not null before using email validation. 
            ValidationResult = CheckForNotNull(obj.emailAddress, "Email");

            Validator<string> emailAddresssValidator = new RegexValidator(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
            var valResults = emailAddresssValidator.Validate(obj.emailAddress);

            if (valResults != null)
            {
                foreach (var varRes in valResults)
                {
                    IValidationMessage val = new EmailNotValidMessage() { TargetName = "Email", ErroringValue = obj.emailAddress };
                    ValidationResult.ValidationMessageList.Add(val);
                }
            }

            return ValidationResult;
        }

        #endregion
    }
}
