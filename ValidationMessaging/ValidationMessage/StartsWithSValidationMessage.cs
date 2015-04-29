using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.MessagingLiteral;

namespace Template.ValidationMessaging
{
    public class StartsWithSValidationMessage: IValidationMessage
    {
        #region IValidationMessage Members

        public MessageTypes MessageType { get { return MessageTypes.Warning; } }

        public string Message { get { return ValidationText.StartsWithSLiteral; } }

        public string TargetName { get; set; }

        public string ErroringValue { get; set; }

        public string MessageToDisplay
        {
            get
            {
                return string.Format("{0} : {1}", ErroringValue, Message);
            }
        }


        #endregion
    }
}
