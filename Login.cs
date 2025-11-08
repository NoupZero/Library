using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class Login : Form
    {
        LibraryBD1 conn = new LibraryBD1();
        private string loginHint = "Логин", passwordHint = "Пароль";
        public Login()
        {
            InitializeComponent();
            textBoxLogin.ForeColor = Color.LightGray;
            textBoxPassword.ForeColor = Color.LightGray;
            RadioButtonReader.Select();
        }
        private void textBoxPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == passwordHint)
            {
                textBoxPassword.Text = "";
                textBoxPassword.ForeColor = Color.Black;
                textBoxPassword.PasswordChar = '•';
            }
        }

        private void textBoxPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "")
            {
                textBoxPassword.Text = passwordHint;
                textBoxPassword.ForeColor = Color.LightGray;
                textBoxPassword.PasswordChar = '\0';
            }
        }

        private void labelToRegistration_MouseEnter(object sender, EventArgs e)
        {
            labelToRegistration.ForeColor = Color.LightBlue;
        }

        private void labelToRegistration_MouseLeave(object sender, EventArgs e)
        {
            labelToRegistration.ForeColor = Color.White;
        }

        private void labelToRegistration_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            registration.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if(RadioButtonReader.Checked)
            {
                if (conn.Readers.Any(u => u.Login == textBoxLogin.Text && u.Password == textBoxPassword.Text))
                {
                    MessageBox.Show("Успешно");
                    MainReader form1 = new MainReader(textBoxLogin.Text);
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильно введенные данные","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (conn.Librarians.Any(u => u.Login == textBoxLogin.Text && u.Password == textBoxPassword.Text))
                {
                    MessageBox.Show("Успешно");
                    MainLibrarian form1 = new MainLibrarian(textBoxLogin.Text);
                    form1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неправильно введенные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == loginHint)
            {
                textBoxLogin.Text = "";
                textBoxLogin.ForeColor = Color.Black;
            }
        }
        private void textBoxLogin_Leave(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "")
            {
                textBoxLogin.Text = loginHint;
                textBoxLogin.ForeColor = Color.LightGray;
            }
        }
    }
}
