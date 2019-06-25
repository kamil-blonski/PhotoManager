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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Test();
        }

        public void Test()
        {
            var dbCon = Database.Instance();
            dbCon.DatabaseName = "photomanager";
            if (dbCon.IsConnect())
            {
                Console.WriteLine("if");
                //suppose col0 and col1 are defined as VARCHAR in the DB
                string query = "SELECT * FROM users";
                var cmd = new MySqlCommand(query, dbCon.Connection);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string someStringFromColumnZero = reader.GetString(0);
                    string someStringFromColumnOne = reader.GetString(1);
                    Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
                }
                dbCon.Close();
            }
        }
    }
}
