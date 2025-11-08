namespace Library
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RadioButtonReader = new System.Windows.Forms.RadioButton();
            this.RadioButtonAdmin = new System.Windows.Forms.RadioButton();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.labelToRegistration = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLogin.Location = new System.Drawing.Point(93, 157);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(204, 31);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.Text = "Логин";
            this.textBoxLogin.Enter += new System.EventHandler(this.textBoxLogin_Enter);
            this.textBoxLogin.Leave += new System.EventHandler(this.textBoxLogin_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.Location = new System.Drawing.Point(93, 194);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(204, 31);
            this.textBoxPassword.TabIndex = 1;
            this.textBoxPassword.Text = "Пароль";
            this.textBoxPassword.Enter += new System.EventHandler(this.textBoxPassword_Enter);
            this.textBoxPassword.Leave += new System.EventHandler(this.textBoxPassword_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(92, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Авторизация";
            // 
            // RadioButtonReader
            // 
            this.RadioButtonReader.AutoSize = true;
            this.RadioButtonReader.BackColor = System.Drawing.Color.Transparent;
            this.RadioButtonReader.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonReader.ForeColor = System.Drawing.Color.White;
            this.RadioButtonReader.Location = new System.Drawing.Point(93, 232);
            this.RadioButtonReader.Name = "RadioButtonReader";
            this.RadioButtonReader.Size = new System.Drawing.Size(106, 28);
            this.RadioButtonReader.TabIndex = 4;
            this.RadioButtonReader.TabStop = true;
            this.RadioButtonReader.Text = "Читатель";
            this.RadioButtonReader.UseVisualStyleBackColor = false;
            // 
            // RadioButtonAdmin
            // 
            this.RadioButtonAdmin.AutoSize = true;
            this.RadioButtonAdmin.BackColor = System.Drawing.Color.Transparent;
            this.RadioButtonAdmin.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RadioButtonAdmin.ForeColor = System.Drawing.Color.White;
            this.RadioButtonAdmin.Location = new System.Drawing.Point(93, 266);
            this.RadioButtonAdmin.Name = "RadioButtonAdmin";
            this.RadioButtonAdmin.Size = new System.Drawing.Size(147, 28);
            this.RadioButtonAdmin.TabIndex = 5;
            this.RadioButtonAdmin.TabStop = true;
            this.RadioButtonAdmin.Text = "Библиотекарь";
            this.RadioButtonAdmin.UseVisualStyleBackColor = false;
            // 
            // buttonEnter
            // 
            this.buttonEnter.BackColor = System.Drawing.Color.White;
            this.buttonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnter.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEnter.Location = new System.Drawing.Point(93, 300);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(204, 43);
            this.buttonEnter.TabIndex = 6;
            this.buttonEnter.Text = "Войти";
            this.buttonEnter.UseVisualStyleBackColor = false;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // labelToRegistration
            // 
            this.labelToRegistration.AutoSize = true;
            this.labelToRegistration.BackColor = System.Drawing.Color.Transparent;
            this.labelToRegistration.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelToRegistration.ForeColor = System.Drawing.Color.White;
            this.labelToRegistration.Location = new System.Drawing.Point(12, 417);
            this.labelToRegistration.Name = "labelToRegistration";
            this.labelToRegistration.Size = new System.Drawing.Size(249, 24);
            this.labelToRegistration.TabIndex = 7;
            this.labelToRegistration.Text = "Нет аккаунта? Жми на меня";
            this.labelToRegistration.Click += new System.EventHandler(this.labelToRegistration_Click);
            this.labelToRegistration.MouseEnter += new System.EventHandler(this.labelToRegistration_MouseEnter);
            this.labelToRegistration.MouseLeave += new System.EventHandler(this.labelToRegistration_MouseLeave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(461, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(10, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Library.Properties.Resources.open_book_beautiful_setting__1___1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelToRegistration);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.RadioButtonAdmin);
            this.Controls.Add(this.RadioButtonReader);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 500);
            this.MinimumSize = new System.Drawing.Size(400, 500);
            this.Name = "Login";
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton RadioButtonReader;
        private System.Windows.Forms.RadioButton RadioButtonAdmin;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Label labelToRegistration;
        private System.Windows.Forms.Button button1;
    }
}

