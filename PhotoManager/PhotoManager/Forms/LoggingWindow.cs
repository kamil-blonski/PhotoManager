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

        #region Properties
        public IRegisterView IVievRegister
		{
			get
			{
				return Register.RegisterInstance;
			}
		}

        public IMainViev IVievForm
        {
            get
            {
                return Main.InstanceForm1;
            }
        }
        #endregion Properties
        private LoggingWindow()
		{
			InitializeComponent();

		}

        #region Events
        public event Action<User> LoggingEvent;
        #endregion Events

        #region Methods
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

		public void hideLoggingWindow()
		{
				obj.Hide();
		}

		private void logInButton_Click(object sender, EventArgs e)
		{
            if((loginTextBox.Text == string.Empty) || (passwordTextBox.Text == string.Empty))
            {
                ShowMessage(false, "Login fields can not be empty.");
                return;
            }

            if (LoggingEvent != null)
            {
                LoggingEvent(new User(loginTextBox.Text, passwordTextBox.Text));
            }
        }

		private void registerButton_Click(object sender, EventArgs e)
		{     
            Register.RegisterInstance.ShowDialog();
		}

        public void ClearTextBoxes()
        {
            loginTextBox.Text = string.Empty;
            passwordTextBox.Text = string.Empty;
        }

        #endregion Methods
    }
}
