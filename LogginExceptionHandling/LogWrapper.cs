using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Template.LogginExceptionHandling;
using System.Reflection;
using log4net;

namespace Template.LogginExceptionHandling
{
	public class LogWrapper
	{
		//Add this line to each file that would need to log something
		private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

		public static bool Log(string message)
		{
			return true;
		}

	}
}
