using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.ValidationMessaging
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple=false, Inherited=true)]
    public class EmptyNotValidAttribute : Attribute
    {
        public EmptyNotValidAttribute()
        {

        }
    }
}
