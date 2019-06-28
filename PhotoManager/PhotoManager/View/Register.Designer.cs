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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.lSurname = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.lLogin = new System.Windows.Forms.Label();
            this.lPassword = new System.Windows.Forms.Label();
            this.gbRegisterForm = new System.Windows.Forms.GroupBox();
            this.bCreateAccount = new System.Windows.Forms.Button();
            this.bGoBack = new System.Windows.Forms.Button();
            this.gbRegisterForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.Location = new System.Drawing.Point(126, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 27);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2.Location = new System.Drawing.Point(126, 54);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(299, 27);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox3.Location = new System.Drawing.Point(126, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(299, 27);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox4.Location = new System.Drawing.Point(126, 224);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(299, 27);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox5.Location = new System.Drawing.Point(126, 179);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(299, 27);
            this.textBox5.TabIndex = 4;
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
            this.gbRegisterForm.Controls.Add(this.bGoBack);
            this.gbRegisterForm.Controls.Add(this.bCreateAccount);
            this.gbRegisterForm.Controls.Add(this.lName);
            this.gbRegisterForm.Controls.Add(this.textBox1);
            this.gbRegisterForm.Controls.Add(this.textBox2);
            this.gbRegisterForm.Controls.Add(this.textBox5);
            this.gbRegisterForm.Controls.Add(this.lPassword);
            this.gbRegisterForm.Controls.Add(this.textBox4);
            this.gbRegisterForm.Controls.Add(this.textBox3);
            this.gbRegisterForm.Controls.Add(this.lLogin);
            this.gbRegisterForm.Controls.Add(this.lSurname);
            this.gbRegisterForm.Controls.Add(this.lEmail);
            this.gbRegisterForm.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbRegisterForm.Location = new System.Drawing.Point(3, 5);
            this.gbRegisterForm.Name = "gbRegisterForm";
            this.gbRegisterForm.Size = new System.Drawing.Size(445, 345);
            this.gbRegisterForm.TabIndex = 10;
            this.gbRegisterForm.TabStop = false;
            this.gbRegisterForm.Text = "Create an account:";
            // 
            // bCreateAccount
            // 
            this.bCreateAccount.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bCreateAccount.Location = new System.Drawing.Point(295, 284);
            this.bCreateAccount.Name = "bCreateAccount";
            this.bCreateAccount.Size = new System.Drawing.Size(130, 39);
            this.bCreateAccount.TabIndex = 10;
            this.bCreateAccount.Text = "Create Account";
            this.bCreateAccount.UseVisualStyleBackColor = true;
            // 
            // bGoBack
            // 
            this.bGoBack.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.bGoBack.Location = new System.Drawing.Point(126, 284);
            this.bGoBack.Name = "bGoBack";
            this.bGoBack.Size = new System.Drawing.Size(134, 39);
            this.bGoBack.TabIndex = 11;
            this.bGoBack.Text = "Go back";
            this.bGoBack.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 354);
            this.Controls.Add(this.gbRegisterForm);
            this.Name = "Register";
            this.Text = "Register";
            this.gbRegisterForm.ResumeLayout(false);
            this.gbRegisterForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.Label lSurname;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label lLogin;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.GroupBox gbRegisterForm;
        private System.Windows.Forms.Button bGoBack;
        private System.Windows.Forms.Button bCreateAccount;
    }
}