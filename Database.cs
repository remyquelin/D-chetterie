using MySql.Data.MySqlClient;

namespace Déchetterie
{
	public static class Database
	{
		private static string host = "localhost";
		private static string database = "dechetterie";
		private static string user = "root";
		private static string password = "";

		public static MySqlConnection GetConnection()
		{
			string connectionString =
				$"Server={host};Database={database};Uid={user};Pwd={password};SslMode=none;";

			return new MySqlConnection(connectionString);
		}
	}
}
