using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using Template.Business.Interface.Domain;

namespace Template.ValidationMessaging
{
    public class BillingCycleRule : IValidationRule
    {
        #region MS Validations

        //String Length Validator as composition
        private StringLengthValidator msStringLengthValidator;
        private NotNullValidator msNotNullValidator;

        #endregion

        public BillingCycleRule()
        {
            this.msStringLengthValidator = new StringLengthValidator(1,5);
            this.msNotNullValidator = new NotNullValidator();
        }

        public BillingCycleRule(ICustomer Customer) : this()
        {
            this.Customer = Customer;
        }

        public ICustomer Customer { get;  private set; }

        #region IValidationRule Members

        public IValidationResult RuleValidationResult {get; private set;}

        public IValidationResult Validate()
        {
            if (!IsOverriden)
            {
                //MS Validation 
                Validator NotNullStringLengthValidator = new AndCompositeValidator(this.msNotNullValidator, this.msStringLengthValidator);

                ValidationResults valResults = NotNullStringLengthValidator.Validate(Customer.customerNumber);

                if (!valResults.IsValid) //if not valid
                {
                    RuleValidationResult = new MyValidationResult();
                    RuleValidationResult.ValidationMessageList.Add(new NullValidationMessage());
                }

                
                if (Customer.EmailList != null)
                {
                    //Some other Random Test Validation. RegexValidator in this case
                    Validator<string> emailAddresssValidator = new RegexValidator(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                    valResults = emailAddresssValidator.Validate(Customer.EmailList.First());
                }
                else
                {
                    valResults = this.msNotNullValidator.Validate(Customer.EmailList);
                }

                //Holidays Own Validation
                
                //RuleValidationResult = valResults;

                if (valResults != null)
                {
                    RuleValidationResult = new MyValidationResult();

                    foreach(var varRes in valResults)
                    {
                        IValidationMessage val = new MSWrapperMessage(MessageTypes.Error, varRes.Message);
                        RuleValidationResult.ValidationMessageList.Add(val);
                    }
                }

            }

            return RuleValidationResult;
        }

        #endregion

        #region IValidationRule Members

        public bool IsOverriden {get; set;}
        
        #endregion
    }
}
