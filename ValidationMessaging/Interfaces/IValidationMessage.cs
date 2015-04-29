using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.ValidationMessaging
{
    public interface IValidationMessage
    {
        /// <summary>
        /// enum such as Error, Warning, Info etc. It can be used to determine what color message to show to end users
        /// </summary>
        MessageTypes MessageType { get;  }
        
        /// <summary>
        /// Literal Validation Message that is displayed to end user
        /// </summary>
        string Message { get; }


        string TargetName { get; }

        string ErroringValue { get; }

        string MessageToDisplay { get; }
    }
}
