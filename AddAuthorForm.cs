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
    public partial class AddAuthorForm : Form
    {
        private string hintFio = "ФИО";
        LibraryBD1 conn = new LibraryBD1();
        public AddAuthorForm()
        {
            InitializeComponent();
            textBoxFio.ForeColor = Color.LightGray;
        }

        private void textBoxFio_Enter(object sender, EventArgs e)
        {
            if (textBoxFio.Text == hintFio)
            {
                textBoxFio.Text = "";
                textBoxFio.ForeColor = Color.Black;
            }
        }
        private void textBoxFio_Leave(object sender, EventArgs e)
        {
            if (textBoxFio.Text == "")
            {
                textBoxFio.Text = hintFio;
                textBoxFio.ForeColor = Color.LightGray;
            }
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            if(textBoxFio.Text != hintFio && textBoxFio.Text != null)
            {
                if (!conn.Authors.Any(a => a.FIO == textBoxFio.Text))
                {
                    Authors addAuthor = new Authors
                    {
                        FIO = textBoxFio.Text
                    };
                    conn.Authors.Add(addAuthor);
                    conn.SaveChanges();
                    MessageBox.Show("Автор добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Такой автор уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
