namespace PhotoManager
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.lSurname = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lLogin = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.gbRegisterForm = new System.Windows.Forms.GroupBox();
            this.bGoBack = new System.Windows.Forms.Button();
            this.bCreateAccount = new System.Windows.Forms.Button();
            this.lNameValidation = new System.Windows.Forms.Label();
            this.lSurnameValidation = new System.Windows.Forms.Label();
            this.lEmailWalidation = new System.Windows.Forms.Label();
            this.lLoginValidation = new System.Windows.Forms.Label();
            this.lPasswordValidation = new System.Windows.Forms.Label();
            this.gbRegisterForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbEmail.Location = new System.Drawing.Point(126, 136);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(299, 27);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.Leave += new System.EventHandler(this.EmailValidation);
            // 
            // tbName
            // 
            this.tbName.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbName.Location = new System.Drawing.Point(126, 54);
            this.tbName.MaxLength = 30;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(299, 27);
            this.tbName.TabIndex = 0;
            this.tbName.Leave += new System.EventHandler(this.NameValidation);
            // 
            // tbSurname
            // 
            this.tbSurname.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbSurname.Location = new System.Drawing.Point(126, 97);
            this.tbSurname.MaxLength = 30;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(299, 27);
            this.tbSurname.TabIndex = 1;
            this.tbSurname.Leave += new System.EventHandler(this.SurnameValidation);
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPassword.Location = new System.Drawing.Point(126, 224);
            this.tbPassword.MaxLength = 10;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(299, 27);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.Leave += new System.EventHandler(this.PasswordValidation);
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbLogin.Location = new System.Drawing.Point(126, 179);
            this.tbLogin.MaxLength = 30;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(299, 27);
            this.tbLogin.TabIndex = 3;
            this.tbLogin.Leave += new System.EventHandler(this.LoginValidation);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lName.Location = new System.Drawing.Point(6, 57);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(54, 19);
            this.lName.TabIndex = 5;
            this.lName.Text = "Name:";
            // 
            // lSurname
            // 
            this.lSurname.AutoSize = true;
            this.lSurname.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lSurname.Location = new System.Drawing.Point(6, 100);
            this.lSurname.Name = "lSurname";
            this.lSurname.Size = new System.Drawing.Size(73, 19);
            this.lSurname.TabIndex = 6;
            this.lSurname.Text = "Surname:";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lEmail.Location = new System.Drawing.Point(6, 139);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(60, 19);
            this.lEmail.TabIndex = 7;
            this.lEmail.Text = "E-mail:";
            this.lEmail.Click += new System.EventHandler(this.label3_Click);
            // 
            // lLogin
            // 
            this.lLogin.AutoSize = true;
            this.lLogin.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lLogin.Location = new System.Drawing.Point(6, 182);
            this.lLogin.Name = "lLogin";
            this.lLogin.Size = new System.Drawing.Size(54, 19);
            this.lLogin.TabIndex = 8;
            this.lLogin.Text = "Login:";
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPassword.Location = new System.Drawing.Point(6, 227);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(79, 19);
            this.lPassword.TabIndex = 9;
            this.lPassword.Text = "Password:";
            // 
            // gbRegisterForm
            // 
            this.gbRegisterForm.Controls.Add(this.lPasswordValidation);
            this.gbRegisterForm.Controls.Add(this.lLoginValidation);
            this.gbRegisterForm.Controls.Add(this.lEmailWalidation);
            this.gbRegisterForm.Controls.Add(this.lSurnameValidation);
            this.gbRegisterForm.Controls.Add(this.lNameValidation);
            this.gbRegisterForm.Controls.Add(this.bGoBack);
            this.gbRegisterForm.Controls.Add(this.bCreateAccount);
            this.gbRegisterForm.Controls.Add(this.lName);
            this.gbRegisterForm.Controls.Add(this.tbEmail);
            this.gbRegisterForm.Controls.Add(this.tbName);
            this.gbRegisterForm.Controls.Add(this.tbLogin);
            this.gbRegisterForm.Controls.Add(this.lPassword);
            this.gbRegisterForm.Controls.Add(this.tbPassword);
            this.gbRegisterForm.Controls.Add(this.tbSurname);
            this.gbRegisterForm.Controls.Add(this.lLogin);
            this.gbRegisterForm.Controls.Add(this.lSurname);
            this.gbRegisterForm.Controls.Add(this.lEmail);
            this.gbRegisterForm.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbRegisterForm.Location = new System.Drawing.Point(3, 5);
            this.gbRegisterForm.Name = "gbRegisterForm";
            this.gbRegisterForm.Size = new System.Drawing.Size(473, 345);
            this.gbRegisterForm.TabIndex = 10;
            this.gbRegisterForm.TabStop = false;
            this.gbRegisterForm.Text = "Create an account:";
            // 
            // bGoBack
            // 
            this.bGoBack.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bGoBack.Location = new System.Drawing.Point(126, 284);
            this.bGoBack.Name = "bGoBack";
            this.bGoBack.Size = new System.Drawing.Size(134, 39);
            this.bGoBack.TabIndex = 6;
            this.bGoBack.Text = "Go back";
            this.bGoBack.UseVisualStyleBackColor = true;
            this.bGoBack.Click += new System.EventHandler(this.bGoBack_Click);
            // 
            // bCreateAccount
            // 
            this.bCreateAccount.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCreateAccount.Location = new System.Drawing.Point(266, 284);
            this.bCreateAccount.Name = "bCreateAccount";
            this.bCreateAccount.Size = new System.Drawing.Size(159, 39);
            this.bCreateAccount.TabIndex = 5;
            this.bCreateAccount.Text = "Create Account";
            this.bCreateAccount.UseVisualStyleBackColor = true;
            this.bCreateAccount.Click += new System.EventHandler(this.CreateAccount);
            // 
            // lNameValidation
            // 
            this.lNameValidation.AutoSize = true;
            this.lNameValidation.Location = new System.Drawing.Point(431, 54);
            this.lNameValidation.Name = "lNameValidation";
            this.lNameValidation.Size = new System.Drawing.Size(26, 29);
            this.lNameValidation.TabIndex = 12;
            this.lNameValidation.Text = "*";
            // 
            // lSurnameValidation
            // 
            this.lSurnameValidation.AutoSize = true;
            this.lSurnameValidation.Location = new System.Drawing.Point(431, 97);
            this.lSurnameValidation.Name = "lSurnameValidation";
            this.lSurnameValidation.Size = new System.Drawing.Size(26, 29);
            this.lSurnameValidation.TabIndex = 13;
            this.lSurnameValidation.Text = "*";
            // 
            // lEmailWalidation
            // 
            this.lEmailWalidation.AutoSize = true;
            this.lEmailWalidation.Location = new System.Drawing.Point(431, 136);
            this.lEmailWalidation.Name = "lEmailWalidation";
            this.lEmailWalidation.Size = new System.Drawing.Size(26, 29);
            this.lEmailWalidation.TabIndex = 14;
            this.lEmailWalidation.Text = "*";
            // 
            // lLoginValidation
            // 
            this.lLoginValidation.AutoSize = true;
            this.lLoginValidation.Location = new System.Drawing.Point(431, 179);
            this.lLoginValidation.Name = "lLoginValidation";
            this.lLoginValidation.Size = new System.Drawing.Size(26, 29);
            this.lLoginValidation.TabIndex = 15;
            this.lLoginValidation.Text = "*";
            // 
            // lPasswordValidation
            // 
            this.lPasswordValidation.AutoSize = true;
            this.lPasswordValidation.Location = new System.Drawing.Point(431, 224);
            this.lPasswordValidation.Name = "lPasswordValidation";
            this.lPasswordValidation.Size = new System.Drawing.Size(26, 29);
            this.lPasswordValidation.TabIndex = 16;
            this.lPasswordValidation.Text = "*";
            // 
            // Register
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(488, 354);
            this.Controls.Add(this.gbRegisterForm);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Register";
            this.Text = "Register";
            this.gbRegisterForm.ResumeLayout(false);
            this.gbRegisterForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lSurname;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.GroupBox gbRegisterForm;
        private System.Windows.Forms.Button bGoBack;
        private System.Windows.Forms.Button bCreateAccount;
        private System.Windows.Forms.Label lPasswordValidation;
        private System.Windows.Forms.Label lLoginValidation;
        private System.Windows.Forms.Label lEmailWalidation;
        private System.Windows.Forms.Label lSurnameValidation;
        private System.Windows.Forms.Label lNameValidation;
    }
}