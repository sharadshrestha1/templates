using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.MessagingLiteral
{
	public class ValidationText
	{
		public static readonly string EmptyOrNullLiteral = @"The field cannot be empty";

		public static readonly string StartsWithSLiteral = @"The value starts with S";

		public static readonly string EmailNotValidFormat = @"The email address is not in valid format";
	}
}
