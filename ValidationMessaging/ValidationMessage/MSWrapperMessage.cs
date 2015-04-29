using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.ValidationMessaging
{
    public class MSWrapperMessage : IValidationMessage
    {
        #region IValidationMessage Members

        public MSWrapperMessage(MessageTypes mt, string message)
        {
            this.MessageType = mt;
            this.Message = message;
        }

        public MessageTypes MessageType {get; set;}

        public string Message { get; set;}

        public string TargetName { get; set; }

        public string ErroringValue { get; set; }

        public string MessageToDisplay
        {
            get
            {
                if(ErroringValue != null)
                    return string.Format("{0} : {1}", ErroringValue, Message);

                return string.Format("{0} : {1}", TargetName, Message);
            }
        }
       
        
        #endregion
    }
}
