using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace PhotoManager
{
    class Database
    {
        private MySqlConnection connection = null;
        private static Database _instance = null;

        private Database() { Console.WriteLine("XD"); }

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


    }

    /*
        https://stackoverflow.com/questions/21618015/how-to-connect-to-mysql-database
    */
}
