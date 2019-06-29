using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhotoManager.Model
{
	class Model
	{
		public Model()
		{

		}
        #region Login
        public bool checkPassword(string formPassword, string dbPassword)
		{
			if (formPassword == dbPassword)
			{
				new Form1().ShowDialog();
				return true;
			}
			else
				return false;
		}
        #endregion Login

        #region Register
        public void CreateAcconut(int? id, string name, string surname, string email, string username, string password)
        {
            //Console.WriteLine(id + " " + name + " " + surname + " " + email + " " + username + " " + password);
            string query = "select count(*) from users where email = \"" + email + "\";";
            if (RecordExist(query))
            {
                MessageBox.Show("Selected email address already exists.", "Error.", MessageBoxButtons.OK);
                return;
            }
            query = "select count(*) from users where login = \"" + username + "\";";
            if (RecordExist(query))
            {
                MessageBox.Show("Selected username  already exists.", "Error.", MessageBoxButtons.OK);
                return;
            }

            var dbCon = Database.Instance();
            dbCon.DatabaseName = "photomanager";
            if (dbCon.IsConnect())
            {
                //SqlCommand con = new SqlCommand("insert into users values(@id, @name, @surname, @login, @password, @email)");
                //string passQuery = "insert into users values(@id,@name,@surname,@login,@password,@email);";
                if (dbCon.Connection.State != ConnectionState.Open)
                {
                    using (MySqlCommand command = dbCon.Connection.CreateCommand())
                    {
                        command.CommandText = "insert into users values(@id,@name,@surname,@login,@password,@email);";
                        command.Parameters.AddWithValue("@id", null);
                        command.Parameters.AddWithValue("@name", name);
                        command.Parameters.AddWithValue("@surname", surname);
                        command.Parameters.AddWithValue("@login", username);
                        command.Parameters.AddWithValue("@email", email);
                        dbCon.Connection.Open();
                        int result = command.ExecuteNonQuery();
                        if (result < 0)
                            MessageBox.Show("Error during inserting data into Database.", "Error", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("New account created correctly.", "Success", MessageBoxButtons.OK);
                    }
                }


                    dbCon.Close();
            }

        }
        #endregion Register

        #region DBPrivatefunctions
        private bool RecordExist(string query)
        {
            int? amountOfRecords = null;
            var dbCon = Database.Instance();
            dbCon.DatabaseName = "photomanager";
            if (dbCon.IsConnect())
            {
                string passQuery = query;
                if (dbCon.Connection.State != ConnectionState.Open)
                {
                    dbCon.Connection.Open();
                }

                var cmd = new MySqlCommand(passQuery, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    amountOfRecords = int.Parse(reader.GetString(0));
                    Console.WriteLine(amountOfRecords);
                }
                dbCon.Close();
            }

            if (amountOfRecords != null && amountOfRecords > 0)
                return true;
            else
                return false;
        }


        #endregion DBPrivatefunctions

    }

}
