using System;
using MySql.Data.MySqlClient;

namespace PhotoManager
{
    public class Database
    {
        private MySqlConnection connection = null;
        private static Database _instance = null;

        private Database() {  }

        private string databaseName = string.Empty;
        public string DatabaseName
        {
            get { return databaseName; }
            set { databaseName = value; }
        }

        public string Password { get; set; }
        
        public MySqlConnection Connection
        {
            get { return connection; }
        }

        public static Database Instance()
        {
            if (_instance == null)
                _instance = new Database();
            return _instance;
        }

        public bool IsConnect()
        {
            if (Connection == null)
            {
                if (String.IsNullOrEmpty(databaseName))
                    return false;
				//Server = localhost

				string connstring = string.Format("Server=localhost; database={0}; UID=root; password=", databaseName);
                connection = new MySqlConnection(connstring);
                connection.Open(); //exception
            }

            return true;
        }

        public void Close()
        {
            connection.Close();
        }

		static public bool RecordExist(string query)
		{
			int? amountOfRecords = null;
			var dbCon = Database.Instance();
			dbCon.DatabaseName = "photomanager";
			if (dbCon.IsConnect())
			{
				
				string passQuery = query;
				if (dbCon.Connection.State != System.Data.ConnectionState.Open)
				{
					dbCon.Connection.Open();
				}

				var cmd = new MySqlCommand(passQuery, dbCon.Connection);
				var reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					amountOfRecords = int.Parse(reader.GetString(0));
				}
				dbCon.Close();
			}

			if (amountOfRecords != null && amountOfRecords > 0)
				return true;
			else
				return false;
		}

	}
    /*
        https://stackoverflow.com/questions/21618015/how-to-connect-to-mysql-database
    */
}
