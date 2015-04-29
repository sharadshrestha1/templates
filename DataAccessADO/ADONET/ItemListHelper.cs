using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Template.DomainInterface;
using System.Data;
using Template.Business;
using Template.LogginExceptionHandling;

namespace Template.DataAccessLayer
{
	public class ItemListHelper: DataAccessHelper
	{
				//No connectionStringName constructor	
		public ItemListHelper(): base()
		{
		}

		public ItemListHelper(string connectionStringName)
			: base(connectionStringName)
		{
		
		}

		public  List<IItemList> ExecuteReader()
		{
			//SE: update this with something usable
			List<IItemList> retList = new List<IItemList>();

			SetUpProviderAndConnection();

			using (DBConnection)
			{
				DBCommand = DBConnection.CreateCommand();
				DBCommand.CommandText = QueryString != null ? QueryString : "Select * from State";
				DBCommand.CommandType = CommandType.Text;

				try
				{
					//Open Connection
					DBConnection.Open();
					//Execute Reader
					DBDataReader = DBCommand.ExecuteReader();
					
                    //while (DBDataReader.Read())
                    //{
                    //    var state = new State((int) DBDataReader[0]
                    //                    , DBDataReader[1].ToString()
                    //                    , DBDataReader[2].ToString());
						
                    //    retList.Add(state);
                    //}
				}
				catch (Exception ex)
				{
					LogWrapper.Log(ex.Message);
				}
			}

			return retList;
		}
	}
}
