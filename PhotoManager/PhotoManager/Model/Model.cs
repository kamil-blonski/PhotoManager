using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.IO;

namespace PhotoManager.Model
{
	class Model
	{
		public Model()
		{

		}
        #region Login
        public bool checkPassword(string formLogin, string formPassword)
        {
            var dbCon = Database.Instance();
            string passwdFromDatabase = null;
            dbCon.DatabaseName = "photomanager";
            if (dbCon.IsConnect())
            {
                string passQuery = "select password from users where login = \"" + formLogin + "\"";

                if (dbCon.Connection.State != ConnectionState.Open)
                {
                    dbCon.Connection.Open();
                }
                var cmd = new MySqlCommand(passQuery, dbCon.Connection);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    passwdFromDatabase = reader.GetString(0);
                }
                dbCon.Close();
            }
            if (passwdFromDatabase != null && SHA1Hash(formPassword) == passwdFromDatabase)
            {
                //new Form1().ShowDialog();
                return true;
            }
            else
                return false;
        }
        #endregion Login

        #region Register
        public bool EmailExists(User user)
        {
            string query = "select count(*) from users where email = \"" + user.Email + "\";";
            if (Database.RecordExist(query))
                return true;
            return false;
        }
        public bool UserExists(User user)
        {
            string query = "select count(*) from users where login = \"" + user.Login + "\";";
            if (Database.RecordExist(query))
                return true;
            return false;
        }
            
        public bool CreateAccount(User user)
        {
            var dbCon = Database.Instance();
            dbCon.DatabaseName = "photomanager";
            if (dbCon.IsConnect())
            {
                if (dbCon.Connection.State != ConnectionState.Open)
                {
                    using (MySqlCommand command = dbCon.Connection.CreateCommand())
                    {
                        command.CommandText = "insert into users values(@id,@name,@surname,@login,@password,@email);";
                        command.Parameters.AddWithValue("@id", null);
                        command.Parameters.AddWithValue("@name", user.Name);
                        command.Parameters.AddWithValue("@surname", user.Surname);
                        command.Parameters.AddWithValue("@login", user.Login);
                        command.Parameters.AddWithValue("@password", SHA1Hash(user.Password));
                        command.Parameters.AddWithValue("@email", user.Email);
                        dbCon.Connection.Open();
                        try
                        {
                            int result = command.ExecuteNonQuery();
                            if (result < 0)
                                return false;
                            else
                                return true;
                        }
                        catch (Exception exc)
                        {
                            MessageBox.Show(exc.ToString());
                        }
                    }
                }
                dbCon.Close();
            }
            return true;
        }
        #endregion Register

        #region Pictures

        public bool AddPhoto(string path, Photo photo)
        {
            try
            {
                FileStream fStream = new FileStream(path, FileMode.Open, FileAccess.Read);
                byte[] data = new byte[fStream.Length];
                fStream.Read(data, 0, (int)fStream.Length);
                fStream.Close();
                //konwertowanie bajtów odczytanych na tekst
                string hex = BitConverter.ToString(data);
                hex = hex.Replace("-", "");

                var dbCon = Database.Instance();
                dbCon.DatabaseName = "photomanager";
                if (dbCon.IsConnect())
                {
                    if (dbCon.Connection.State != ConnectionState.Open)
                    {
                        using (MySqlCommand command = dbCon.Connection.CreateCommand())
                        {
                            command.CommandText = "insert into photos values(@id,@name,@creationdate,@description,@format,@size,@pictureB);";
                            command.Parameters.AddWithValue("@id", null);
                            command.Parameters.AddWithValue("@name", photo.Name);
                            command.Parameters.AddWithValue("@creationdate", photo.CreationDate);
                            command.Parameters.AddWithValue("@description", photo.Description);
                            command.Parameters.AddWithValue("@format", photo.Format);
                            command.Parameters.AddWithValue("@size", photo.PhotoSize);
                            command.Parameters.AddWithValue("@pictureB", hex);
                            dbCon.Connection.Open();
                            try
                            {
                                int result = command.ExecuteNonQuery();
                                if (result < 0)
                                    return false;
                                else
                                    return true;
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.ToString());
                            }
                        }
                    }
                    dbCon.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("DODAWANIE ZDJĘCIA BŁĄD", "Error", MessageBoxButtons.OK); //tego tu nie bedzie
            }
            return false;
        }

        #endregion Pictures

        #region Other
        public string SHA1Hash(string s)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(s);
            var sha1 = SHA1.Create();
            byte[] hashBytes = sha1.ComputeHash(bytes);
            return HexStringFromBytes(hashBytes);
        }

        public static string HexStringFromBytes(byte[] bytes)
        {
            var sb = new StringBuilder();
            foreach (byte b in bytes)
            {
                var hex = b.ToString("x2");
                sb.Append(hex);
            }
            return sb.ToString();
        }
        #endregion Other

    }

}
