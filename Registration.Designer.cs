namespace Library
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            this.labelBackToLogin = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelBackToLogin
            // 
            this.labelBackToLogin.AutoSize = true;
            this.labelBackToLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelBackToLogin.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBackToLogin.ForeColor = System.Drawing.Color.White;
            this.labelBackToLogin.Location = new System.Drawing.Point(11, 419);
            this.labelBackToLogin.Name = "labelBackToLogin";
            this.labelBackToLogin.Size = new System.Drawing.Size(246, 24);
            this.labelBackToLogin.TabIndex = 14;
            this.labelBackToLogin.Text = "Есть аккаунт? Жми на меня";
            this.labelBackToLogin.Click += new System.EventHandler(this.labelBackToLogin_Click);
            this.labelBackToLogin.MouseEnter += new System.EventHandler(this.labelBackToLogin_MouseEnter);
            this.labelBackToLogin.MouseLeave += new System.EventHandler(this.labelBackToLogin_MouseLeave);
            // 
            // buttonCreate
            // 
            this.buttonCreate.BackColor = System.Drawing.Color.White;
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCreate.Location = new System.Drawing.Point(92, 310);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(204, 43);
            this.buttonCreate.TabIndex = 6;
            this.buttonCreate.Text = "Создать";
            this.buttonCreate.UseVisualStyleBackColor = false;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(96, 66);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(200, 40);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Регистрация";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(92, 236);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(204, 31);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Text = "Пароль";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(92, 199);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(204, 31);
            this.textBoxLogin.TabIndex = 3;
            this.textBoxLogin.Text = "Логин";
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // textBoxRepeatPassword
            // 
            this.textBoxRepeatPassword.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRepeatPassword.Location = new System.Drawing.Point(92, 273);
            this.textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            this.textBoxRepeatPassword.Size = new System.Drawing.Size(204, 31);
            this.textBoxRepeatPassword.TabIndex = 5;
            this.textBoxRepeatPassword.Text = "Подтверждение";
            this.textBoxRepeatPassword.Enter += new System.EventHandler(this.textBoxRepeatPassword_Enter);
            this.textBoxRepeatPassword.Leave += new System.EventHandler(this.textBoxRepeatPassword_Leave);
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLastName.Location = new System.Drawing.Point(92, 162);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(204, 31);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.Text = "Фамилия";
            this.textBoxLastName.Enter += new System.EventHandler(this.textBoxLastName_Enter);
            this.textBoxLastName.Leave += new System.EventHandler(this.textBoxLastName_Leave);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFirstName.Location = new System.Drawing.Point(92, 125);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(204, 31);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.Text = "Имя";
            this.textBoxFirstName.Enter += new System.EventHandler(this.textBoxFirstName_Enter);
            this.textBoxFirstName.Leave += new System.EventHandler(this.textBoxFirstName_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(409, 373);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(11, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Создать";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.open_book_beautiful_setting__1___1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxRepeatPassword);
            this.Controls.Add(this.labelBackToLogin);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "Registration";
            this.Text = "Регистрация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Registration_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelBackToLogin;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxRepeatPassword;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Button button1;
    }
}