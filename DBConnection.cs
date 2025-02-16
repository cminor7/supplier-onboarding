using System.Data;
using System.Data.SqlClient;
using Snowflake.Data.Client;

namespace ONBOARDING
{
	internal class DBConnection
	{
		readonly private static string racfid = Environment.UserName.ToUpper();
		readonly private static string sfConnString = $"account=wwgrainger.us-east-1;user={racfid};authenticator=externalbrowser;database=TERADATA;warehouse=GSCCE_ETL_S;role=ISP_SVC";
		readonly private static string sqlConnString = "Data Source=PR-ITMGMT.us.grainger.com; Initial Catalog=Itemmanagement;Integrated Security=true";
		readonly private static SnowflakeDbConnection sfConn = new(sfConnString);
		readonly private static SqlConnection sqlConn = new(sqlConnString);

		public static void SnowflakeCommand(string query)
		{
			if (sfConn.State == ConnectionState.Closed || sfConn.State == ConnectionState.Broken) sfConn.Open();
			SnowflakeDbCommand cmd = new() { Connection = sfConn, CommandText = query };
			cmd.ExecuteNonQuery();
		}

		public static DataView SnowflakeView(string query)
		{
			if (sfConn.State == ConnectionState.Closed || sfConn.State == ConnectionState.Broken) sfConn.Open();
			SnowflakeDbCommand cmd = new() { Connection = sfConn, CommandText = query };
			var reader = cmd.ExecuteReader();
			DataTable dataTable = new();
			dataTable.Load(reader);
			DataView dv = new(dataTable);
			reader.Close();
			dataTable.Dispose();
			return dv;
		}

		public static object ExecuteScalarQuery(string query)
		{
			if (sqlConn.State == ConnectionState.Closed || sqlConn.State == ConnectionState.Broken) sqlConn.Open();
			SqlCommand sqlCmd = new(query, sqlConn);
			return sqlCmd.ExecuteScalar();
		}

		public static DataView SQLView(string query)
		{
			if (sqlConn.State == ConnectionState.Closed || sqlConn.State == ConnectionState.Broken) sqlConn.Open();
			SqlCommand sqlCmd = new(query, sqlConn);
			SqlDataReader reader = sqlCmd.ExecuteReader();
			DataTable dataTable = new();
			dataTable.Load(reader);
			DataView dv = new(dataTable);
			reader.Close();
			dataTable.Dispose();
			return dv;
		}

		public static void SQLCommand(string query)
		{
			if (sqlConn.State == ConnectionState.Closed || sqlConn.State == ConnectionState.Broken) sqlConn.Open();
			SqlCommand cmd = new(query, sqlConn);
			cmd.ExecuteNonQuery();
		}

		public static void CloseConnections()
		{
			if (sfConn.State == ConnectionState.Open) sfConn.Close();
			if (sqlConn.State == ConnectionState.Open) sqlConn.Close();
		}
	}
}