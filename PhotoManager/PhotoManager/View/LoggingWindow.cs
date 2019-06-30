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
	public partial class LoggingWindow : Form, IView
	{
		private static LoggingWindow obj;

		public IRegisterView IVievRegister
		{
			get
			{
				return Register.RegisterInstance;
			}
		}

        public IForm1View IVievForm
        {
            get
            {
                return Form1.InstanceForm1;
            }
        }

        private LoggingWindow()
		{
			InitializeComponent();

		}

        // implement interface
        //public event Action<string, string> LoggingEvent;
        public event Action<string, string> LoggingEvent;
        public void ShowMessage(bool success, string message)
		{
			MessageBox.Show(message, success ? "Message" : "Error", MessageBoxButtons.OK);
		}

		public static LoggingWindow getInstance()
		{
			if (obj == null)
				obj = new LoggingWindow();
			
			return obj;
		}

		public static void hideLoggingWindow()
		{
				obj.Hide();
		}


        //public string TBUserName
        //{
        //    set { loginTextBox.Text = value; }
        //}
        //public string TBPassword
        //{
        //    set { passwordTextBox.Text = value; }
        //}

		private void logInButton_Click(object sender, EventArgs e)
		{
            if((loginTextBox.Text == string.Empty) || (passwordTextBox.Text == string.Empty))
            {
                ShowMessage(false, "Login fields can not be empty.");
                return;
            }
            if (LoggingEvent != null)
                LoggingEvent(loginTextBox.Text, passwordTextBox.Text);
        }

		private void registerButton_Click(object sender, EventArgs e)
		{
            //this.Visible = false;
           
            Register.RegisterInstance.Show();
		}
	}
}
