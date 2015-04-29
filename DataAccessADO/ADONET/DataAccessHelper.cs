using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;
using System.Configuration;
using Template.LogginExceptionHandling;

namespace Template.DataAccessLayer
{
	public class DataAccessHelper : IDisposable
	{
		//No connectionStringName constructor	
		public DataAccessHelper()
		{
			//Default the connectionStringName to
			connectionStringName = "DataAccessCommon";
		}

		public DataAccessHelper(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#region Connection String

		private string connectionStringName;
		protected string ConnectionStringName
		{
			get 
			{
				return connectionStringName; 
			}
			set
			{
				connectionStringName = value;
			}
		}
		#endregion

		public string QueryString { get; set; }

		protected DbConnection DBConnection { get; set; }
		protected DbCommand DBCommand { get; set; }
		protected DbCommandBuilder DBCommandBuilder { get; set; }
		protected DbDataReader DBDataReader { get; set; }
		protected DbDataAdapter DBDataAdapter { get; set; }
		protected DbProviderFactory ProviderFactory { get; set; }

		public void SetUpProviderAndConnection()
		{
			//Get the connecitonStringsettings from config
			ConnectionStringSettings connection = ConfigurationManager.ConnectionStrings[ConnectionStringName];
			ProviderFactory = DbProviderFactories.GetFactory(connection.ProviderName);

			//Create the connection string and equate the connectionstring from config
			DBConnection = ProviderFactory.CreateConnection();
			DBConnection.ConnectionString = connection.ConnectionString;
		}


		public virtual void ExecuteReader()
		{
			SetUpProviderAndConnection();

			using (DBConnection)
			{
				DBCommand = DBConnection.CreateCommand();
				DBCommand.CommandText = QueryString!=null?QueryString:"Select * from State";
				DBCommand.CommandType = CommandType.Text;

				try
				{
					//Open Connection
					DBConnection.Open();
					//Execute Reader
					DBDataReader = DBCommand.ExecuteReader();
					
					//SE: update this with something usable
					var retList = new List<string>();
					
					while (DBDataReader.Read())
					{
						retList.Add(DBDataReader[0].ToString());
					}
				}
				catch (Exception ex)
				{
					LogWrapper.Log(ex.Message);
				}
			}
		}


		public List<string> ExecuteQuery(DbConnection dbConnection)
		{
			if (dbConnection == null)
			{
				string message = "DBConnection cannot be null for using this method";
				LogginExceptionHandling.LogWrapper.Log(message);
				throw new ArgumentNullException("dbConnection", message);
			}

			if (String.IsNullOrEmpty(QueryString))
			{
				string message = "ConnectionStringName cannot be null for using this method";
				LogginExceptionHandling.LogWrapper.Log(message);
				throw new ArgumentNullException("ConnectionStringName", message);
			}

			using (dbConnection)
			{
				DBCommand = dbConnection.CreateCommand();
				DBCommand.CommandText = QueryString;
				DBCommand.CommandType = CommandType.Text;

				try
				{
					dbConnection.Open();
					DBDataReader = DBCommand.ExecuteReader();
					var retList = new List<string>();
					while (DBDataReader.Read())
					{

						retList.Add(DBDataReader[0].ToString());
					}
					return retList;
				}
				catch (Exception ex)
				{
					LogginExceptionHandling.LogWrapper.Log(ex.Message);
				}
			}

			return null;
		}


		#region IDisposable Members

		protected bool disposed;

		protected virtual void Dispose(bool disposing)
		{
			if (!disposed)
			{
				if (disposing)
				{
					if (DBDataReader != null)
						DBDataReader.Close();

					if (DBCommand != null)
						DBCommand.Dispose();

					if (DBConnection != null)
						DBConnection.Close();
				
				}

				disposed = true;
			}
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}

		#endregion

	}
}
