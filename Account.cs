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
    public partial class Account : Form
    {
        private string hintNowPassword = "Старый пароль", hintNewPassword = "Новый пароль", hintAccess = "Подтверждение", password;
        private int rID;
        private int who;
        LibraryBD1 conn = new LibraryBD1();
        public Account(int isWho, int ID)
        {
            InitializeComponent();
            rID = ID;
            who = isWho;
            if(who == 1)
            {
                password = conn.Readers.SingleOrDefault(p => p.ID_Reader == rID).Password;
                textBoxNewPassword.ForeColor = Color.LightGray;
                textBoxNowPassword.ForeColor = Color.LightGray;
                textBoxAccess.ForeColor = Color.LightGray;

                labelFirstName.Text = "Имя: " + conn.Readers.SingleOrDefault(f => f.ID_Reader == rID).FirstName;
                labelLastName.Text = "Фамилия: " + conn.Readers.SingleOrDefault(f => f.ID_Reader == rID).LastName;
                labelLogin.Text = "Логин: " + conn.Readers.SingleOrDefault(f => f.ID_Reader == rID).Login;
            }
            else
            {
                password = conn.Librarians.SingleOrDefault(p => p.ID_librarian == rID).Password;
                textBoxNewPassword.ForeColor = Color.LightGray;
                textBoxNowPassword.ForeColor = Color.LightGray;
                textBoxAccess.ForeColor = Color.LightGray;

                labelFirstName.Text = "Имя: " + conn.Librarians.SingleOrDefault(f => f.ID_librarian == rID).FirstName;
                labelLastName.Text = "Фамилия: " + conn.Librarians.SingleOrDefault(f => f.ID_librarian == rID).LastName;
                labelLogin.Text = "Логин: " + conn.Librarians.SingleOrDefault(f => f.ID_librarian == rID).Login;
            }

        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            if(textBoxAccess.Text != hintAccess||textBoxNowPassword.Text != hintNowPassword||textBoxNewPassword.Text != hintNewPassword)
            {
                if(textBoxNowPassword.Text == password)
                {
                    if (textBoxNewPassword.Text != textBoxNowPassword.Text)
                    {
                        if (textBoxNewPassword.Text == textBoxAccess.Text)
                        {
                            DialogResult dialog = DialogResult.OK;
                            if(dialog == MessageBox.Show("Вы уверены, что хотите поменять пароль?", "Предупреждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                            {
                                if(who == 1)
                                {
                                    Readers newPassword = conn.Readers.SingleOrDefault(c => c.ID_Reader == rID);
                                    newPassword.Password = textBoxNewPassword.Text;
                                    conn.SaveChanges();
                                    MessageBox.Show("Пароль успешно изменён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }
                                else
                                {
                                    Librarians newPassword = conn.Librarians.SingleOrDefault(c => c.ID_librarian == rID);
                                    newPassword.Password = textBoxNewPassword.Text;
                                    conn.SaveChanges();
                                    MessageBox.Show("Пароль успешно изменён", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    this.Close();
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("Пароли не совпадают", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Новый пароль должен отличаться от предыдущего", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Старый пароль не совпадает с тем, что вы ввели", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxNowPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxNowPassword.Text == hintNowPassword)
            {
                textBoxNowPassword.Text = "";
                textBoxNowPassword.ForeColor = Color.Black;
                textBoxNowPassword.PasswordChar = '•';
            }
        }

        private void textBoxNowPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxNowPassword.Text == "")
            {
                textBoxNowPassword.Text = hintNowPassword;
                textBoxNowPassword.ForeColor = Color.LightGray;
                textBoxNowPassword.PasswordChar = '\0';
            }
        }

        private void textBoxNewPassword_Enter(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == hintNewPassword)
            {
                textBoxNewPassword.Text = "";
                textBoxNewPassword.ForeColor = Color.Black;
                textBoxNewPassword.PasswordChar = '•';
            }
        }

        private void textBoxNewPassword_Leave(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text == "")
            {
                textBoxNewPassword.Text = hintNewPassword;
                textBoxNewPassword.ForeColor = Color.LightGray;
                textBoxNewPassword.PasswordChar = '\0';
            }
        }

        private void textBoxAccess_Enter(object sender, EventArgs e)
        {
            if (textBoxAccess.Text == hintAccess)
            {
                textBoxAccess.Text = "";
                textBoxAccess.ForeColor = Color.Black;
                textBoxAccess.PasswordChar = '•';
            }
        }

        private void textBoxAccess_Leave(object sender, EventArgs e)
        {
            if (textBoxAccess.Text == "")
            {
                textBoxAccess.Text = hintAccess;
                textBoxAccess.ForeColor = Color.LightGray;
                textBoxAccess.PasswordChar = '\0';
            }
        }

    }
}
