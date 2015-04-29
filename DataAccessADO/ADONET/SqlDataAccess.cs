using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;
using System.Data.SqlClient;
using Template.DomainInterface;
using Template.Business;
using System.Data;
using Template.LogginExceptionHandling;
using Template.MessagingLiteral;
using Template.Business.Interface.Domain;

namespace Template.DataAccessLayer.ADONET
{
	public class SqlDataAccess
	{

		#region Connection String 
		public string ConnectionString
		{
			get { return ConfigurationManager.ConnectionStrings[_ConnectionStringName].ConnectionString; }
		}

		private string _ConnectionStringName;
		public string ConnectionStringName
		{
			get { return _ConnectionStringName; }
			set { _ConnectionStringName = value; }
		}

		#endregion

		public SqlConnection sqlConnection
		{
			get { return new SqlConnection(ConnectionString); }
		}

		private string _SqlStatement;
		public string SqlStatement
		{
			get { return _SqlStatement; }
			set { _SqlStatement = value; }
		}


        //public IDomainObject GetEntityById<T>(object id)
        //{
        //    var bizEmail = new Email();

        //    //Some DataAcess Code to populate Email

        //    // step 1: formulate a string containing the details of the
        //    // database connection
        //    //string connectionString = "server=localhost;database=Northwind;uid=sa;pwd=sa";

        //    // step 2: create a SqlConnection object to connect to the
        //    // database, passing the connection string to the constructor
        //    SqlConnection mySqlConnection =  new SqlConnection(ConnectionString);

        //    // step 3: formulate a SELECT statement to retrieve the
        //    // CustomerID, CompanyName, ContactName, and Address
        //    // columns for the first ten rows from the Customers table
			
        //    //string selectString =
        //    //  "SELECT CustomerID, CompanyName, ContactName, Address " +
        //    //  "FROM Customers " +
        //    //  "WHERE CustomerID < 'BSBEV'";

        //    // step 4: create a SqlCommand object to hold the SELECT statement
        //    SqlCommand mySqlCommand = mySqlConnection.CreateCommand();

        //    // step 5: set the CommandText property of the SqlCommand object to
        //    // the SELECT string
        //    mySqlCommand.CommandText = SqlStatement;

        //    // step 6: create a SqlDataAdapter object
        //    SqlDataAdapter mySqlDataAdapter = new SqlDataAdapter();

        //    // step 7: set the SelectCommand property of the SqlAdapter object
        //    // to the SqlCommand object
        //    mySqlDataAdapter.SelectCommand = mySqlCommand;

        //    // step 8: create a DataSet object to store the results of
        //    // the SELECT statement
        //    DataSet myDataSet = new DataSet();

        //    // step 9: open the database connection using the
        //    // Open() method of the SqlConnection object
        //    mySqlConnection.Open();

        //    // step 10: use the Fill() method of the SqlDataAdapter object to
        //    // retrieve the rows from the table, storing the rows locally
        //    // in a DataTable of the DataSet object
        //    LogWrapper.Log(LogText.GettingData);
			
        //    string dataTableName = "Email";
			
        //    mySqlDataAdapter.Fill(myDataSet, dataTableName);

        //    // step 11: get the DataTable object from the DataSet object
        //    DataTable myDataTable = myDataSet.Tables[dataTableName];

        //    // step 12: display the columns for each row in the DataTable,
        //    // using a DataRow object to access each row in the DataTable
        //    foreach (DataRow myDataRow in myDataTable.Rows)
        //    {
        //        bizEmail.customerId = (int)myDataRow["CustomerID"];
        //        bizEmail.emailAddress = (string)myDataRow["EmailAddress"];
        //        bizEmail.emailId = (int)myDataRow["EmailID"];
        //    }

        //    // step 13: close the database connection using the Close() method
        //    // of the SqlConnection object created in Step 2
        //    mySqlConnection.Close();

        //    return (IDomainObject)bizEmail;
        //}


	}
}
