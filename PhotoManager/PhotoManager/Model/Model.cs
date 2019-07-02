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
using System.Drawing.Imaging;

namespace PhotoManager.Model
{
    class Model
    {
        #region Fields
        private User CurrentUser;
        private Album CurrentAlbum;
        private Photo CurrentPhoto;
		private List<Photo> dbPhotos;
		#endregion Fields

		#region Propetries
		#endregion Properties

		#region Login
		public bool checkPassword(User user)
        {
            var dbCon = Database.Instance();
            string passwdFromDatabase = null;
            dbCon.DatabaseName = "photomanager";
            if (dbCon.IsConnect())
            {
                string passQuery = "select password from users where login = \"" + user.Login + "\"";
                
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
            if (passwdFromDatabase != null && SHA1Hash(user.Password) == passwdFromDatabase)
            {
                CurrentUser = CurrentUserFullData(user); //żeby była referencja do obiektu aktualnie zalogowanego uzytkownika w modelu
                return true;
            }
            else
                return false;
        }

        private User CurrentUserFullData(User user)
        {
            var dbCon = Database.Instance();
            dbCon.DatabaseName = "photomanager";
            if (dbCon.IsConnect())
            {
                string passQuery = "select * from users where login = \"" + user.Login + "\"";

                if (dbCon.Connection.State != ConnectionState.Open)
                {
                    dbCon.Connection.Open();
                }
                var cmd = new MySqlCommand(passQuery, dbCon.Connection);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                { 
                    user = new User(int.Parse(reader.GetString(0)), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetString(5));
                }
                dbCon.Close();              
            }
            return user;
        }

        public void LoadForm1Instance()
        {
            Form1.InstanceForm1.ShowDialog();
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
                            dbCon.Close();
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
                
            }
            return true;
        }
        #endregion Register

        #region Album

        private void AddCreation()
        {
            try
            {
                var dbCon = Database.Instance();
                dbCon.DatabaseName = "photomanager";
                if (dbCon.IsConnect())
                {
                    ///Console.WriteLine("Addcreation: " + dbCon.Connection.State);
                    if (dbCon.Connection.State != ConnectionState.Open)
                    {
                        using (MySqlCommand command = dbCon.Connection.CreateCommand())
                        {
                            command.CommandText = "insert into creation values(@id_u,@id_a);";
                            command.Parameters.AddWithValue("@id_u", CurrentUser.ID);
                            command.Parameters.AddWithValue("@id_a", CurrentAlbum.ID);
                            dbCon.Connection.Open();
                            try
                            {
                                int result = command.ExecuteNonQuery();
                                dbCon.Close();
                                if (result < 0)
                                    throw new Exception();
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.ToString(), "Problem podczas dodawania albumu.");
                            }
                        }
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("DODAWANIE ZDJĘCIA BŁĄD", "Error", MessageBoxButtons.OK); //tego tu nie bedzie
            }

        }

		// załadowanie albumów do comboBoxa z bazy
		public List<Album> GetAlbums()
		{
			var dbCon = Database.Instance();
			dbCon.DatabaseName = "photomanager";
			if (dbCon.IsConnect())
			{
                string passQuery = "select a.id, a.name, a.creationdate, a.description, a.type from albums a join creation c on a.id = c.id_a where c.id_u = \"" + CurrentUser.ID + "\";";

                if (dbCon.Connection.State != ConnectionState.Open)
				{
					dbCon.Connection.Open();
				}
				var cmd = new MySqlCommand(passQuery, dbCon.Connection);

				var reader = cmd.ExecuteReader();

                while (reader.Read())
				{
                    CurrentUser.addAlbum((new Album(int.Parse(reader.GetString(0)), reader.GetString(1), DateTime.Parse(reader.GetString(2)), reader.GetString(3), reader.GetString(4))));
				}
				dbCon.Close();
                CurrentAlbum = CurrentUser.Albums[0]; //domyślnie załadowany album to zawsze pierwszy, to trzeba poprawić
			}
			return CurrentUser.Albums;
		}

        public bool AddAlbum(Album album)
        {
            try
            {
                var dbCon = Database.Instance();
                dbCon.DatabaseName = "photomanager";
                if (dbCon.IsConnect())
                {
                    if (dbCon.Connection.State != ConnectionState.Open)
                    {
                        using (MySqlCommand command = dbCon.Connection.CreateCommand())
                        {
                            command.CommandText = "insert into albums values(@id,@name,@creationdate,@description,@type);";
                            command.Parameters.AddWithValue("@id", null);
                            command.Parameters.AddWithValue("@name", album.Name);
                            command.Parameters.AddWithValue("@creationdate", album.CreationDate.ToString("yyyy-MM-dd HH:mm:ss"));
                            command.Parameters.AddWithValue("@description", album.Description);
                            command.Parameters.AddWithValue("@type", album.SelectedType);


                            dbCon.Connection.Open();
                            try
                            {
                                int result = command.ExecuteNonQuery();
                                dbCon.Close();
                                if (result < 0)
                                    return false;
                                else
                                {
                                    CurrentAlbum = album;
                                    CurrentAlbum.ID = GetLastID("albums"); //wszystkie dane o albumie są oprócz ID, więc je pobieram
                                    AddCreation();
                                    return true;
                                }
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.ToString(), "Problem podczas dodawania albumu.");
                            }
                        }
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("DODAWANIE ZDJĘCIA BŁĄD", "Error", MessageBoxButtons.OK); //tego tu nie bedzie
            }
            return true;
        }

        public Album NewAlbumListElement()
        {
            CurrentUser.addAlbum(CurrentAlbum);
            return CurrentAlbum;
        }
    
        private int GetLastID(string column)//pobranie ID dodanego właśnie albumu
        {
            int id = 0;
            var dbCon = Database.Instance();
            dbCon.DatabaseName = "photomanager";
            if (dbCon.IsConnect())
            {
                string passQuery = "select id from "+ column + " order by id desc limit 1;";

                if (dbCon.Connection.State != ConnectionState.Open)
                {
                    dbCon.Connection.Open();
                }
                var cmd = new MySqlCommand(passQuery, dbCon.Connection);

                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    id = int.Parse(reader.GetString(0));
                }
                dbCon.Close();
            }
            return id;
        }
        #endregion Album

        #region Photos

        public bool AddPhoto(string path, Photo photo, Album album)
        {
            Console.WriteLine("AddPhoto");
            try
            {
                var dbCon = Database.Instance();
                dbCon.DatabaseName = "photomanager";
                if (dbCon.IsConnect())
                {
                    if (dbCon.Connection.State != ConnectionState.Open)
                    {
                        using (MySqlCommand command = dbCon.Connection.CreateCommand())
                        {
                            command.CommandText = "insert into photos values(@id,@name,@creationdate,@format,@size,@pictureB);";
                            command.Parameters.AddWithValue("@id", null);
                            command.Parameters.AddWithValue("@name", photo.Name);
                            command.Parameters.AddWithValue("@creationdate", photo.CreationDate);
                            command.Parameters.AddWithValue("@format", photo.Format.ToString());
                            command.Parameters.AddWithValue("@size", photo.PhotoSize);
                            command.Parameters.AddWithValue("@pictureB", Photo.EncodePhoto(path));
                            dbCon.Connection.Open();
                            try
                            {
                                int result = command.ExecuteNonQuery();
                                dbCon.Close();
                                if (result < 0)
                                    return false;
                                else
                                {
                                    CurrentPhoto = photo;
                                    CurrentPhoto.ID = GetLastID("photos");
                                    CurrentAlbum = album;
                                    AddOwnership(); //powiązanie zdjęcia z albumem;

                                    return true;    
                                }
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.ToString(), "Problem podczas dodawania zdjęcia.");
                            }
                        }
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("DODAWANIE ZDJĘCIA BŁĄD", "Error", MessageBoxButtons.OK); //tego tu nie bedzie
            }
            return true;
        }

        private void AddOwnership()
        {
            Console.WriteLine("Dodaje ownership ");
            try
            {
                var dbCon = Database.Instance();
                dbCon.DatabaseName = "photomanager";
                if (dbCon.IsConnect())
                {
                    Console.WriteLine("XD1");
                    if (dbCon.Connection.State != ConnectionState.Open)
                    {
                        Console.WriteLine("XD2");
                        using (MySqlCommand command = dbCon.Connection.CreateCommand())
                        {
                            Console.WriteLine("XD3");
                            command.CommandText = "insert into ownership values(@id_a,@id_p);";
                            command.Parameters.AddWithValue("@id_a", CurrentAlbum.ID);
                            command.Parameters.AddWithValue("@id_p", CurrentPhoto.ID);
                            dbCon.Connection.Open();
                            try
                            {
                                int result = command.ExecuteNonQuery();
                                dbCon.Close();
                                Console.WriteLine("result" + result);
                                if (result < 0)
                                    throw new Exception();
                            }
                            catch (Exception exc)
                            {
                                MessageBox.Show(exc.ToString(), "Problem podczas dodawania ownership.");
                            }
                        }
                    }
                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("DODAWANIE OWNERSHIP BŁĄD" + ex,  "Error", MessageBoxButtons.OK); //tego tu nie bedzie
            }
        }

        public void ReadPhoto(int AlbumID)
        {
            //To dopiero jak bede meić liste obiektów obiekt Album dla zalogowanego Usera, bo jest tam lista zdjęć. 
        }


		public List<Photo> LoadPhotosToAlbum() //argument to aktualnie wbrnay album
		{
			var dbCon = Database.Instance();
			dbCon.DatabaseName = "photomanager";
			if (dbCon.IsConnect())
			{
				//dbPhotos = new List<Photo>();

				//daj blobiki
				string query = "select * from photos;";
				if (dbCon.Connection.State != System.Data.ConnectionState.Open)
				{
					dbCon.Connection.Open();
				}

				var cmd = new MySqlCommand(query, dbCon.Connection);
				var reader = cmd.ExecuteReader();
				while (reader.Read())
                { 
                    CurrentAlbum.addPhoto(new Photo(int.Parse(reader.GetString(0)), reader.GetString(1), DateTime.Parse(reader.GetString(2)), ImageFormat.Jpeg, double.Parse(reader.GetString(4)), Photo.DecodePhoto(reader.GetString(5))));
				}
				dbCon.Close();
			}
            foreach (Photo xd in CurrentAlbum.PhotoList)
                Console.WriteLine(xd.Name);

			return CurrentAlbum.PhotoList;
		}

		#endregion Photos

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
