using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace InternetPhoneBook.Helpers
{
	public class SqlHelper
	{
		static string connectionString = "Server=tcp:internet-phonebook.database.windows.net,1433;Initial Catalog=internet-phonebook-database;Persist Security Info=False;User ID=kamilwojcik;Password=asdf123%;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

		public static SqlConnection GetConnection()
		{
			SqlConnection conn = new SqlConnection(connectionString);
			conn.Open();
			return conn;
		}
	}
}
