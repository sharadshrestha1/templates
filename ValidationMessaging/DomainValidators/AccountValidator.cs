using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Template.Business.Interface.Domain;


namespace Template.ValidationMessaging
{
    public class CustomerValidator : MyValidator, IValidator<ICustomer>
    {
        #region IValidator<ICustomer> Members

        public IValidationResult Validate(ICustomer obj)
        {
            return Validate(obj, false);
        }

        public IValidationResult Validate(ICustomer obj, bool suppressWarnings)
        {
            IValidationRule billRule = new BillingCycleRule(obj);

            IValidationResult result = billRule.Validate();

            if (suppressWarnings)
            {
                result.ValidationMessageList.RemoveAll(m => m.MessageType == MessageTypes.Warning);
            }

            return result;
        }

        #endregion
    }
 

}
