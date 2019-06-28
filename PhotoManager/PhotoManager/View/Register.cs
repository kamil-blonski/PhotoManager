using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoManager
{
    public partial class Register : Form, IRegisterViev
    {
        private string name;
        private string surname;
        private string username;
        private string password;
        private string email;
        #region Propertis
        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                this.surname = value;
            }
        }

        public string UserName
        {
            get
            {
                return username;
            }

            set
            {
                this.username = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                this.password = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                this.email = value;
            }
        }
        #endregion Propertis
        public Register()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
