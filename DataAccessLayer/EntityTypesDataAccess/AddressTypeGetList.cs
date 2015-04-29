//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;

//using Template.Utilities;
//using biz = Template.BusinessLayer;
//using Template.BusinessInterface.Enums;

//namespace Template.DataAccessLayer
//{
//    public class AddressTypeGetList 
//    {
//        public IList<biz.BaseEntityType> GetList()
//        {
//            var acsTypes = from acs in EntityData_Context.Customers
//                           select acs;

//            if (acsTypes.Any())
//            {
//                var CustomerStatusList = new List<biz.BaseEntityType>();

//                foreach (var acStat in acsTypes)
//                {
//                    var CustomerStatus = new biz.AddressType();
//                    acStat.MapClass(CustomerStatus);
//                    CustomerStatusList.Add(CustomerStatus);
//                }

//                return CustomerStatusList;
//            }
//            return null;
//        }
//    }
//}
