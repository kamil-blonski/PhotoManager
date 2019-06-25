using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PhotoManager
{
	public partial class LoggingWindow : Form
	{
		private static LoggingWindow obj;
		private LoggingWindow()
		{
			InitializeComponent();
		}

		public static LoggingWindow getInstance()
		{
			if (obj == null)
				obj = new LoggingWindow();
			return obj;
		}

		private void logInButton_Click(object sender, EventArgs e)
		{
			string login = loginTextBox.Text;
			//new Form1().Show();
			var dbCon = Database.Instance();
			dbCon.DatabaseName = "photomanager";
			if (dbCon.IsConnect())
			{ 
				string passQuery = "select password from users where login = \""+login+"\"";
				var cmd = new MySqlCommand(passQuery, dbCon.Connection);
				var reader = cmd.ExecuteReader();
				while (reader.Read())
				{
					string passwdFromDatabase = reader.GetString(0);
					if(passwordTextBox.Text == passwdFromDatabase)
					{
						new Form1().Show();
					}
					Console.WriteLine(passwdFromDatabase);
				}
				dbCon.Close();
			}
		}

		private void registerButton_Click(object sender, EventArgs e)
		{

		}
	}
}
