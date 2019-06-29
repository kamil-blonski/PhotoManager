using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoManager
{
    public partial class Register : Form, IRegisterViev
    {
        //Rejestracia wciśnięciem entera ??
        private static Register registerInstance;
        private Register()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        #region Fields
        private bool nameCorrect = false;
        private bool surnameCorrect = false;
        private bool emailCorrect = false;
        private bool loginCorrect = false;
        private bool passwordCorrect = false;
        #endregion Fields;

        #region Events
        public event Action<User> CreateAccountEvent;
        #endregion Events

        public static Register RegisterInstance
        {
            get
            {
                if (registerInstance == null)
                    registerInstance = new Register();
                return registerInstance;
            }
        }

        //Function used to data validation. AFTER posotive evaluation, data go throught presenter to model.
        //spacja w wyrażeniu regularnym a nie przy pomocy Contains
        #region Validation

        private bool IsEmpty(string tb)
        {
            if (tb.Trim() == string.Empty)
                return true;
            else
                return false;
        }

        private bool HasSpecialSIgns(string tb)
        {
            Regex regNumbers = new Regex("[@#$%^&*()]"); 
            if (regNumbers.IsMatch(tb) || tb.Contains(" "))
            {
                return true;
            }
            return false;
        }
        private bool HasNumbers(string tb)
        {
            Regex regNumbers = new Regex("[0-9]"); 
            if (regNumbers.IsMatch(tb) || tb.Contains(" "))
            {
                return true;
            }
            return false;
        }

        private void NameValidation(object sender, EventArgs e)
        {
            //NameR = tbName.Text;
            if (IsEmpty(tbName.Text) || HasNumbers(tbName.Text) || HasSpecialSIgns(tbName.Text))
            {
                lNameValidation.ForeColor = Color.Red;
                nameCorrect = false;
                return;
            }
            else
            {
                lNameValidation.ForeColor = Color.Green;
            }
            nameCorrect = true;
        }

        private void SurnameValidation(object sender, EventArgs e)
        {
			//Surname = tbSurname.Text;
			//tempUser.Surname = tbSurname.Text;
            if (IsEmpty(tbSurname.Text) || HasNumbers(tbSurname.Text) || HasSpecialSIgns(tbSurname.Text))
            {
                lSurnameValidation.ForeColor = Color.Red;
                surnameCorrect = false;
                return;
            }
            else
            {
                lSurnameValidation.ForeColor = Color.Green;
            }

            surnameCorrect = true;
        }

        private void EmailValidation(object sender, EventArgs e)
        {
            //Email = tbEmail.Text;
            Regex reg = new Regex(@"^(?!\.)(""([^""\r\\]|\\[""\r\\])*""|" + @"([-a-z0-9!#$%&'*+/=?^_`{|}~]|(?<!\.)\.)*)(?<!\.)" + @"@[a-z0-9][\w\.-]*[a-z0-9]\.[a-z][a-z\.]*[a-z]$");

            if (IsEmpty(tbEmail.Text) || !reg.IsMatch(tbEmail.Text))
            {
                lEmailWalidation.ForeColor = Color.Red;
                emailCorrect = false;
                return;
            }
            else
            {
                lEmailWalidation.ForeColor = Color.Green;
            }

            emailCorrect = true;
        }

        private void LoginValidation(object sender, EventArgs e)
        {
            //UserName = tbLogin.Text;
            if (IsEmpty(tbLogin.Text) || HasSpecialSIgns(tbLogin.Text))
            {
                lLoginValidation.ForeColor = Color.Red;
                loginCorrect = false;
                return;
            }
            else
            {
                lLoginValidation.ForeColor = Color.Green;
            }

            loginCorrect = true;
        }

        private void PasswordValidation(object sender, EventArgs e)
        {
            //Password = tbPassword.Text;
            if (IsEmpty(tbPassword.Text))
            {
                lPasswordValidation.ForeColor = Color.Red;
                passwordCorrect = false;
                return;
            }
            else
            {
                lPasswordValidation.ForeColor = Color.Green;
            }

            
            passwordCorrect = true;
        }
        
        #endregion Validation

        private void CreateAccount(object sender, EventArgs e)
        {
            
            if(nameCorrect && surnameCorrect && emailCorrect && loginCorrect && passwordCorrect)
            {
                if (CreateAccountEvent != null)

                    CreateAccountEvent(new User());
            }
            else
            {
                MessageBox.Show("You must correctly innput all data. Check your input with red dots.", "Error", MessageBoxButtons.OK);
            }

        }

        private void bGoBack_Click(object sender, EventArgs e)
        {
            //pojawienie się z powrotem kokna logowania

        }

		private void bCreateAccount_Click(object sender, EventArgs e)
		{
			try
			{
				CreateAccountEvent(new User(null, tbName.Text, tbSurname.Text, tbLogin.Text, tbPassword.Text, tbEmail.Text));

			}
			catch(Exception exc)
			{
				MessageBox.Show(exc.ToString());
			}
		}

	
	}
}
