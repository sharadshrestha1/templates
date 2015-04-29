using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Template.Business.Interface.Domain
{
	public interface IEntityType
	{
		int ID { get; }
		string DisplayText { get; }

		IList<IEntityType> GetList();
	}
}
