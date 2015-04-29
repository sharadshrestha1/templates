using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface.Enums;
using Template.DomainInterface;

namespace Template.Business
{
	/// <summary>
	/// Simple factory for Getting List of EntityType 
	/// </summary>
    public class EntityTypeFactory
    {
		public static IList<BaseEntityType> GetEntityTypes(enmEntityTypes entType)
        {
			IList<BaseEntityType> list = null;

			switch (entType)
			{
				case enmEntityTypes.PhoneType:
					using (var et = new PhoneType())
						list = et.GetList();
					break;
				case enmEntityTypes.AddressType:
					using (var et = new AddressType())
						list = et.GetList();
					break;
				case enmEntityTypes.EmailType:
					using (var et = new EmailType())
						list = et.GetList();
					break;
				default:
					break;
			}

            return list;
        }
    }
}
