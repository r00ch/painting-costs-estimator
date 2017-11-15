using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estimator.Library
{
	public static class GlobalConfig
	{
		public static IDataConnection Connection { get; private set; } 

		public static void InitializeConnection(bool database, bool textFiles)
		{
			if (database)
			{
				// TODO - Set up the SQL Connector properly.
				SqlConnector sql = new SqlConnector();
				Connection = sql;
			}
			else if (textFiles)
			{
				// TODO - Create a text connection.
				TextConnector text = new TextConnector();
				Connection = text;
			}
		}
	}
}
