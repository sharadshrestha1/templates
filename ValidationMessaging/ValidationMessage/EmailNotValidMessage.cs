using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.MessagingLiteral;

namespace Template.ValidationMessaging.ValidationMessage
{
    public class EmailNotValidMessage: IValidationMessage
    {
        #region IValidationMessage Members

        public MessageTypes MessageType { get { return MessageTypes.Error; } }

        public string Message { get { return ValidationText.EmailNotValidFormat; } }

        public string TargetName { get; set; }

        public string ErroringValue { get; set; }

        public string MessageToDisplay
        {
            get
            {
                return string.Format("{0} : {1}", ErroringValue,  Message);
            }
        }

        #endregion
    }
    
}
