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
    public partial class AddBookForm : Form
    {
        private string hintName = "Название", hintCount = "Кол-во";
        LibraryBD1 conn = new LibraryBD1();
        public AddBookForm()
        {
            InitializeComponent();

            textBoxName.ForeColor = Color.LightGray;

            var authors = conn.Authors.ToList();
            comboBoxAuthors.DataSource = authors;
            comboBoxAuthors.DisplayMember = "FIO"; // поле для отображения
            comboBoxAuthors.ValueMember = "ID_Author"; // поле для получения значения

            var books = conn.Genres.ToList();
            comboBoxGenre.DataSource = books.ToList();
            comboBoxGenre.DisplayMember = "Name_Genre"; // поле для отображения
            comboBoxGenre.ValueMember = "ID_Genre"; // поле для получения значения

        }
        private void textBoxName_Enter(object sender, EventArgs e)
        {
            if (textBoxName.Text == hintName)
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


        private void AddBook_Click(object sender, EventArgs e)
        {
            if(textBoxName.Text != hintName && numericUpDownCount.Value > 0)
            {

                var selectedAuthor = (Authors)comboBoxAuthors.SelectedItem;
                var selectedGenre = (Genres)comboBoxGenre.SelectedItem;
                int BookId = selectedAuthor.ID_Author;
                if (conn.Books.Any(b=>(b.Name == textBoxName.Text) && (b.ID_Author == selectedAuthor.ID_Author)))
                {
                    MessageBox.Show("Такая книга уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Books addBook = new Books
                    {
                        Name = textBoxName.Text,
                        ID_Author = selectedAuthor.ID_Author,
                        ID_Genre = selectedGenre.ID_Genre,
                        YearOfPublication = (int)numericUpDown1.Value,
                        Count = (int)numericUpDownCount.Value
                    };
                    conn.Books.Add(addBook);
                    conn.SaveChanges();
                    MessageBox.Show("Книга добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Заполните все поля","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
