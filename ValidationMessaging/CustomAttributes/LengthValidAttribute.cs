using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.ValidationMessaging
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
    public class LengthValidAttribute: Attribute
    {
        private int? _MinLength;
        public int? MinLength
        {
            get { return _MinLength; }
            set { _MinLength = value; }
        }

        private int? _MaxLength;
        public int? MaxLength
        {
            get { return _MaxLength; }
            set { _MaxLength = value; }
        }

        public LengthValidAttribute(int? minLength, int? maxLength)
        {
            _MinLength = minLength;
            _MaxLength = minLength;
        }

        public LengthValidAttribute(int length)
        {
            _MinLength = length;
            _MaxLength = length;
        }



    }
}
