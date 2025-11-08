using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class CreateOrder : Form
    {
        private int ID_reader;
        private int authorId;
        LibraryBD1 conn = new LibraryBD1();
        public CreateOrder(int id_reader)
        {
            ID_reader = id_reader;
            InitializeComponent();
            

            var authors = conn.Authors.ToList();
            comboBoxAuthors.DataSource = authors;
            comboBoxAuthors.DisplayMember = "FIO"; 
            comboBoxAuthors.ValueMember = "ID_Author"; 

            var selectedAuthor  = (Authors)comboBoxAuthors.SelectedItem;
            authorId = selectedAuthor.ID_Author;

            var books = conn.Books.Where(b=>b.ID_Author == authorId && b.Count > 0).ToList();
            comboBoxBooks.DataSource = books.ToList();
            comboBoxBooks.DisplayMember = "Name"; 
            comboBoxBooks.ValueMember = "ID_Book"; 
        }

        private void buttonCreateOrder_Click(object sender, EventArgs e)
        {
            var selectedBook = (Books)comboBoxBooks.SelectedItem;
            int BookId = selectedBook.ID_Book;
            if (!conn.Orders.Any(r=>r.ID_Reader == ID_reader && r.ID_Book == BookId))
            {               
                DateTime date = new DateTime();
                date = DateTime.Now;
                Orders addOrder = new Orders
                {
                    ID_Reader = ID_reader,
                    ID_Book = BookId,
                    Date_Order = date.Date,
                    Status = "Не выдана"
                };
                conn.Books.SingleOrDefault(b => b.ID_Book == BookId).Count -= 1;
                conn.Orders.Add(addOrder);

                conn.SaveChanges();
                MessageBox.Show("Заказ оформлен, приходите за ней в нашу библиотеку", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Вы уже заказали эту книгу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBoxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedAuthor = (Authors)comboBoxAuthors.SelectedItem;
            authorId = selectedAuthor.ID_Author;

            var books = conn.Books.Where(b => b.ID_Author == authorId && b.Count > 0).ToList();
            comboBoxBooks.DataSource = books.ToList();
            comboBoxBooks.DisplayMember = "Name"; 
            comboBoxBooks.ValueMember = "ID_Book"; 
        }
    }
}
