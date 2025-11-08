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
    public partial class AddGenreForm : Form
    {
        LibraryBD1 conn = new LibraryBD1();
        private string hintName = "Название";
        public AddGenreForm()
        {
            InitializeComponent();
            textBoxName.ForeColor = Color.LightGray;
        }

        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if(textBoxName.Text == hintName)
            {
                textBoxName.Text = "";
                textBoxName.ForeColor = Color.Black;
            }
        }

        private void textBoxName_Leave(object sender, EventArgs e)
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = hintName;
                textBoxName.ForeColor = Color.LightGray;
            }
        }

        private void buttonAddGenre_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text != hintName && textBoxName.Text != null)
            {
                if(!conn.Genres.Any(g=>g.Name_Genre == textBoxName.Text))
                {
                    Genres genres = new Genres
                    {
                        Name_Genre = textBoxName.Text
                    };
                    conn.Genres.Add(genres);
                    conn.SaveChanges();
                    MessageBox.Show("Жанр успешно добавлен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Такой жанр уже есть","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля","Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
