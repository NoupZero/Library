namespace Library
{
    partial class ProfileLibrarian
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNowPassword = new System.Windows.Forms.TextBox();
            this.textBoxAccess = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(119, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 40);
            this.label1.TabIndex = 15;
            this.label1.Text = "Профиль";
            // 
            // textBoxNowPassword
            // 
            this.textBoxNowPassword.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNowPassword.Location = new System.Drawing.Point(87, 245);
            this.textBoxNowPassword.Name = "textBoxNowPassword";
            this.textBoxNowPassword.Size = new System.Drawing.Size(226, 31);
            this.textBoxNowPassword.TabIndex = 14;
            this.textBoxNowPassword.Text = "Старый пароль";
            this.textBoxNowPassword.Enter += new System.EventHandler(this.textBoxNowPassword_Enter);
            this.textBoxNowPassword.Leave += new System.EventHandler(this.textBoxNowPassword_Leave);
            // 
            // textBoxAccess
            // 
            this.textBoxAccess.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAccess.Location = new System.Drawing.Point(87, 319);
            this.textBoxAccess.Name = "textBoxAccess";
            this.textBoxAccess.Size = new System.Drawing.Size(226, 31);
            this.textBoxAccess.TabIndex = 13;
            this.textBoxAccess.Text = "Подтверждение";
            this.textBoxAccess.Enter += new System.EventHandler(this.textBoxAccess_Enter);
            this.textBoxAccess.Leave += new System.EventHandler(this.textBoxAccess_Leave);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNewPassword.Location = new System.Drawing.Point(87, 282);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(226, 31);
            this.textBoxNewPassword.TabIndex = 12;
            this.textBoxNewPassword.Text = "Новый пароль";
            this.textBoxNewPassword.Enter += new System.EventHandler(this.textBoxNewPassword_Enter);
            this.textBoxNewPassword.Leave += new System.EventHandler(this.textBoxNewPassword_Leave);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.AutoSize = true;
            this.buttonChangePassword.BackColor = System.Drawing.Color.White;
            this.buttonChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonChangePassword.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonChangePassword.Location = new System.Drawing.Point(87, 370);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(226, 40);
            this.buttonChangePassword.TabIndex = 11;
            this.buttonChangePassword.Text = "Изменить пароль";
            this.buttonChangePassword.UseVisualStyleBackColor = false;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(33, 178);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(206, 31);
            this.labelLogin.TabIndex = 10;
            this.labelLogin.Text = "Логин: SashaDam";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.ForeColor = System.Drawing.Color.White;
            this.labelLastName.Location = new System.Drawing.Point(33, 133);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(241, 31);
            this.labelLastName.TabIndex = 9;
            this.labelLastName.Text = "Фамилия: Дамьянов";
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.ForeColor = System.Drawing.Color.White;
            this.labelFirstName.Location = new System.Drawing.Point(33, 93);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(133, 31);
            this.labelFirstName.TabIndex = 8;
            this.labelFirstName.Text = "Имя: Саша";
            // 
            // ProfileLibrarian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.open_book_beautiful_setting__1___1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNowPassword);
            this.Controls.Add(this.textBoxAccess);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.buttonChangePassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "ProfileLibrarian";
            this.Text = "Профиль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNowPassword;
        private System.Windows.Forms.TextBox textBoxAccess;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button buttonChangePassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelFirstName;
    }
}