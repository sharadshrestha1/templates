using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface;
using System.Reflection;
using Template.Business.Interface.Domain;

namespace Template.ValidationMessaging
{
    public class AddressValidator: MyValidator, IValidator<IAddress>
    {
        #region IValidator<IAddress> Members

        public IValidationResult Validate(IAddress obj)
        {
            return Validate(obj, false);
        }

        public IValidationResult Validate(IAddress obj, bool suppressWarnings)
        {
            return CommonValidate(obj, suppressWarnings);
        }

        #endregion
    }
}
