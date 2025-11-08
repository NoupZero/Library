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
    public partial class Registration : Form
    {
        LibraryBD1 conn = new LibraryBD1();
        private string FirstNameHint = "Имя",
            LastNameHint = "Фамилия",
            loginHint = "Логин", 
            passwordHint = "Пароль",
            passwordAccessHint = "Подтверждение";
        public Registration()
        {
            InitializeComponent();
            textBoxLogin.ForeColor = Color.LightGray;
            textBoxPassword.ForeColor = Color.LightGray;
            textBoxRepeatPassword.ForeColor = Color.LightGray;
            textBoxFirstName.ForeColor = Color.LightGray;
            textBoxLastName.ForeColor = Color.LightGray;
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

        private void textBoxRepeatPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxRepeatPassword.Text == passwordAccessHint)
            {
                textBoxRepeatPassword.Text = "";
                textBoxRepeatPassword.ForeColor = Color.Black;
                textBoxRepeatPassword.PasswordChar = '•';
            }
        }

        private void textBoxRepeatPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxRepeatPassword.Text == "")
            {
                textBoxRepeatPassword.Text = passwordAccessHint;
                textBoxRepeatPassword.ForeColor = Color.LightGray;
                textBoxRepeatPassword.PasswordChar = '\0';
            }
        }

        private void labelBackToLogin_MouseEnter(object sender, EventArgs e)
        {
            labelBackToLogin.ForeColor = Color.LightBlue;
        }

        private void labelBackToLogin_MouseLeave(object sender, EventArgs e)
        {
            labelBackToLogin.ForeColor = Color.White;
        }

        private void labelBackToLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }



        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void textBoxLastName_Enter(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == LastNameHint)
            {
                textBoxLastName.Text = "";
                textBoxLastName.ForeColor = Color.Black;
            }
        }

        private void textBoxLastName_Leave(object sender, EventArgs e)
        {
            if (textBoxLastName.Text == "")
            {
                textBoxLastName.Text = LastNameHint;
                textBoxLastName.ForeColor = Color.LightGray;
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text != loginHint && textBoxPassword.Text != passwordHint && textBoxRepeatPassword.Text != passwordAccessHint && textBoxPassword != null)
            {
              
                if (textBoxPassword.Text == textBoxRepeatPassword.Text)
                {
                    if (conn.Readers.Any(u => u.Login == textBoxLogin.Text))
                    {
                        MessageBox.Show("Такой логин уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Readers addpt = new Readers
                        {
                            FirstName = textBoxFirstName.Text,
                            LastName = textBoxLastName.Text,
                            Login = textBoxLogin.Text,
                            Password = textBoxPassword.Text
                        };
                        conn.Readers.Add(addpt);
                        conn.SaveChanges();
                        MessageBox.Show("Регистрация успешно выполнена", "Информация", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        Login login = new Login();
                        login.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxRepeatPassword.Focus();
                }


            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
    }


        private void textBoxFirstName_Enter(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == FirstNameHint)
            {
                textBoxFirstName.Text = "";
                textBoxFirstName.ForeColor = Color.Black;
            }
        }
        private void textBoxFirstName_Leave(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == "")
            {
                textBoxFirstName.Text = FirstNameHint;
                textBoxFirstName.ForeColor = Color.LightGray;
            }

        }


        private void textBoxLogin_Enter(object sender, EventArgs e)
        {
            if(textBoxLogin.Text == loginHint)
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
