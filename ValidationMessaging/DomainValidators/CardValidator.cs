using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface;
using System.Reflection;
using Template.Business.Interface.Domain;

namespace Template.ValidationMessaging
{
    public class PhoneValidator: MyValidator, IValidator<IPhone>
    {
        #region IValidator<IAddress> Members

        public IValidationResult Validate(IPhone obj)
        {
            return Validate(obj, false);
        }

        public IValidationResult Validate(IPhone obj, bool suppressWarnings)
        {
            return CommonValidate(obj, suppressWarnings);
        }

        #endregion
    }
}
