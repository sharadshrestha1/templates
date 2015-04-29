using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.Business.Interface.Domain;
using Template.DomainInterface;

namespace Template.ValidationMessaging
{
    public static class ValidationFactory
    {
        public static IValidator<T> GetValidator<T>() 
        {
            IValidator<T> entityValidator = null ;

            if(typeof(T) == typeof(ICustomer))
            {
                entityValidator = (IValidator<T>) new CustomerValidator();
            }
            else if (typeof(T) == typeof(IAddress))
            {
                entityValidator = (IValidator<T>)new AddressValidator();
            }

            else if (typeof(T) == typeof(IEmail))
            {
                entityValidator = (IValidator<T>)new EmailValidator();
            }
            else if (typeof(T) == typeof(IPhone))
            {
                entityValidator = (IValidator<T>)new PhoneValidator();
            }

            return entityValidator;
        }

    }
}
