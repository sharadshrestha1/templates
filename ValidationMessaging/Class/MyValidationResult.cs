﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Template.ValidationMessaging
{
    public sealed class MyValidationResult: IValidationResult
    {
        public MyValidationResult()
        {
            ValidationMessageList = new List<IValidationMessage>();
        }

        #region IValidationResult Members

        public List<IValidationMessage> ValidationMessageList{get; private set;}

        //If there is any Messages, then IsValid becomes false
        private bool? isValid;
        public bool IsValid 
        { 
           
            get 
            {
                if (isValid == null)
                    return !ValidationMessageList.Any();

                return isValid.Value;
            } 
        }

       /// <summary>
       /// Overrides autogenerated IsValid property
       /// </summary>
       /// <param name="isValid">Set IsValid to true or false</param>
        public void OverrideIsValid(bool isValid)
        {
            this.isValid = isValid;
        }

       /// <summary>
       /// Defaults IsValid property
       /// </summary>
        public void SetDefaultIsValid()
        {
            this.isValid = null;
        }

        #endregion
    }
}
