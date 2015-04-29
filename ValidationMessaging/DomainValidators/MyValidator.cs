using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;
using Microsoft.Practices.EnterpriseLibrary.Validation;
using System.Reflection;

namespace Template.ValidationMessaging
{
    public class MyValidator
    {
        public  List<IValidationRule> ValidationRuleList { get; set; }
        public IValidationResult ValidationResult { get; set; }

        /// <summary>
        /// The reason to composite MS Validators instead of using them direclty is because in any senario we would want to replace them
        /// we can just swap out those with whatever validators we would like keeping the business layer unchanged. It create a layer
        /// that separates direct using of 3rd party validator.
        /// </summary>
        protected NotNullValidator MSNotNullValidator;
        protected StringLengthValidator msStringLengthValidator;

        public void AggregateValidationRule(IValidationRule ValidationRule)
        {
            if (ValidationRuleList == null)
                ValidationRuleList = new List<IValidationRule>();

            ValidationRuleList.Add(ValidationRule);
        }

        public void AggregateValidationResult(IValidationResult validationResult)
        {
            if (ValidationResult == null)
                ValidationResult = new MyValidationResult();

            ValidationResult.ValidationMessageList.AddRange(validationResult.ValidationMessageList);
        }
      
        
        public IValidationResult CheckForNotNull(object obj, string propName)
        {
            if (MSNotNullValidator == null)
                MSNotNullValidator = new NotNullValidator();

            ValidationResults valResults =  MSNotNullValidator.Validate(obj);
           
            if (valResults != null)
            {
                if (ValidationResult == null)
                    ValidationResult = new MyValidationResult();

                foreach(var varRes in valResults)
                {
                    IValidationMessage val = new MSWrapperMessage(MessageTypes.Error, varRes.Message)
                        { TargetName = propName };
                    ValidationResult.ValidationMessageList.Add(val);
                }
            }
            return ValidationResult;
        }

        public IValidationResult CheckForLength(object obj, int minLenght,  int maxLength, string propName)
        {
            if (msStringLengthValidator == null)
                msStringLengthValidator = new StringLengthValidator(minLenght, maxLength);
            else if (msStringLengthValidator.LowerBound != minLenght 
                || msStringLengthValidator.UpperBound != msStringLengthValidator.UpperBound)
            {
                msStringLengthValidator = new StringLengthValidator(minLenght, maxLength);
                
            }

            ValidationResults valResults = msStringLengthValidator.Validate(obj);
             
            if (valResults != null)
            {
                if (ValidationResult == null)
                    ValidationResult = new MyValidationResult();

                foreach(var varRes in valResults)
                {
                    IValidationMessage val = new MSWrapperMessage(MessageTypes.Error, varRes.Message)
                        { TargetName = propName, ErroringValue = obj.ToString()};
                    ValidationResult.ValidationMessageList.Add(val);
                }
            }

            return ValidationResult;
        }

        /// <summary>
        /// using Reflection, this method looks for any validator attribute adorning properties in an object and checks for the validation respectively
        /// </summary>
        /// <param name="obj">object that has validation to be done</param>
        /// <param name="suppressWarnings">bool to suppress warnings if there is any</param>
        /// <returns></returns>
        public IValidationResult CommonValidate(object obj, bool suppressWarnings)
        {
            foreach (PropertyInfo pi in obj.GetType().GetProperties())
            {
                if (pi.GetCustomAttributes(true).Any())
                {
                    //EmptyNotValid
                    if (pi.GetCustomAttributes(typeof(EmptyNotValidAttribute), true).Any())
                    {
                        foreach (EmptyNotValidAttribute attr in pi.GetCustomAttributes(typeof(EmptyNotValidAttribute), true))
                        {
                            object val = pi.GetValue(obj, null);
                            CheckForNotNull(val, pi.Name);
                        }
                    }

                    //LengthValid
                    if (pi.GetCustomAttributes(typeof(LengthValidAttribute), true).Any())
                    {
                        foreach (LengthValidAttribute len in pi.GetCustomAttributes(typeof(LengthValidAttribute), true))
                        {
                            object val = pi.GetValue(obj, null);
                            if(val != null)
                                CheckForLength(val, len.MinLength.Value, len.MaxLength.Value, pi.Name);
                        }

                    }
                }


            }
            return ValidationResult;
        }
    }
}
