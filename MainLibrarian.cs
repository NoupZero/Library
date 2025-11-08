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
    public partial class MainLibrarian : Form
    {
        private int id;
        LibraryBD1 conn = new LibraryBD1();
        BindingSource bs = new BindingSource();
        public MainLibrarian(string login)
        {
            InitializeComponent();
            id = conn.Librarians.SingleOrDefault(x => x.Login == login).ID_librarian;
            string firstName = conn.Librarians.SingleOrDefault(x => x.ID_librarian == id).FirstName;
            string lastName = conn.Librarians.SingleOrDefault(x => x.ID_librarian == id).LastName;
            this.Text = firstName + " " + lastName;
            labelName.Text = firstName + " " + lastName;
            numericUpDownIDOrder.TextChanged += numericUpDownIDOrder_TextChanged;
            numericUpDownIDorderReturn.TextChanged += numericUpDownIDorderReturn_TextChanged;
        }
  
        private void MainAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxIDoreder_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int orderid = Convert.ToInt32(numericUpDownIDOrder.Value);
                var TakeOrder = from o in conn.Orders
                                join r in conn.Readers on o.ID_Reader equals r.ID_Reader
                                join b in conn.Books on o.ID_Book equals b.ID_Book
                                select new { o.ID_Order, b.ID_Book, b.Name, r.FirstName, r.LastName, o.Status};
                dataTables.DataSource = TakeOrder.Where(c => c.ID_Order.Equals(orderid)).ToList();
                dataTables.Columns[0].HeaderText = "ID заказа";
                dataTables.Columns[1].HeaderText = "ID книги";
                dataTables.Columns[2].HeaderText = "Название книги";
                dataTables.Columns[3].HeaderText = "Имя заказчика";
                dataTables.Columns[4].HeaderText = "Фамилия заказчика";
                dataTables.Columns[5].HeaderText = "Статус заказа";
            }
            catch { }
            finally { }
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataTables.SelectedCells[0].Value.ToString());
                var item = conn.Orders.Where(c => c.ID_Order == id).First();
                if (item.Status != "Выдана")
                {
                    item.Status = "Выдана";
                    item.Date_Return = DateTime.Now.Date.AddDays(7);
                    conn.SaveChanges();
                    MessageBox.Show("Книга выдана", "Инфомрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Книга уже выдана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                int orderid = Convert.ToInt32(numericUpDownIDOrder.Value);
                var TakeOrder = from o in conn.Orders
                                join r in conn.Readers on o.ID_Reader equals r.ID_Reader
                                join b in conn.Books on o.ID_Book equals b.ID_Book
                                where o.Status == "Не выдана"
                                select new { o.ID_Order, b.ID_Book, b.Name, r.FirstName, r.LastName, o.Status };
                dataTables.DataSource = TakeOrder.Where(c => c.ID_Order.Equals(orderid)).ToList();
                dataTables.DataSource = TakeOrder.Where(c => c.ID_Order.Equals(orderid)).ToList();
                dataTableReturn.DataSource = TakeOrder.Where(c => c.ID_Order.Equals(orderid)).ToList();
            }
            catch 
            {
                MessageBox.Show("Введите ID заказа", "Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
                numericUpDownIDOrder.Select();
            }
            finally { }



        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(dataTableReturn.SelectedCells[0].Value.ToString());
                int orderid = Convert.ToInt32(numericUpDownIDorderReturn.Value);
                var item = conn.Orders.Where(c => c.ID_Order == id).First();
                int bookid = conn.Books.SingleOrDefault(b => b.ID_Book == item.ID_Book).ID_Book;
                if (item.Status != "Не выдана")
                {
                    conn.Orders.Remove(item);
                    conn.Books.SingleOrDefault(b => b.ID_Book == bookid).Count += 1;
                    conn.SaveChanges();
                    MessageBox.Show("Книга принята", "Инфомрация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Книга не была выдана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


               
                var TakeOrder = from o in conn.Orders
                                join r in conn.Readers on o.ID_Reader equals r.ID_Reader
                                join b in conn.Books on o.ID_Book equals b.ID_Book
                                select new { o.ID_Order, b.ID_Book, b.Name, r.FirstName, r.LastName, o.Status };
                dataTableReturn.DataSource = TakeOrder.Where(c => c.ID_Order.Equals(orderid) && c.Status == "Выдана").ToList();
                dataTables.DataSource = TakeOrder.Where(c => c.ID_Order.Equals(orderid) && c.Status == "Не выдана").ToList();
            }
            catch
            {
                MessageBox.Show("Введите ID заказа", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpDownIDorderReturn.Select();
            }
            finally { }

        }

        private void buttonProfile_MouseEnter(object sender, EventArgs e)
        {
            buttonProfile.BackColor = Color.LightGray;
        }

        private void buttonProfile_MouseLeave(object sender, EventArgs e)
        {
            buttonProfile.BackColor = Color.White;
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Account profile = new Account(2,id);
            profile.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();

        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            AddBookForm add = new AddBookForm();
            add.ShowDialog();
        }

        private void numericUpDownIDOrder_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int orderid = Convert.ToInt32(numericUpDownIDOrder.Value);
                var TakeOrder = from o in conn.Orders
                                join r in conn.Readers on o.ID_Reader equals r.ID_Reader
                                join b in conn.Books on o.ID_Book equals b.ID_Book
                                where o.Status == "Не выдана"
                                select new { o.ID_Order, b.ID_Book, b.Name, r.FirstName, r.LastName, o.Status };
                dataTables.DataSource = TakeOrder.Where(c => c.ID_Order.Equals(orderid)).ToList();
                dataTables.Columns[0].HeaderText = "ID заказа";
                dataTables.Columns[1].HeaderText = "ID книги";
                dataTables.Columns[2].HeaderText = "Название книги";
                dataTables.Columns[3].HeaderText = "Имя заказчика";
                dataTables.Columns[4].HeaderText = "Фамилия заказчика";
                dataTables.Columns[5].HeaderText = "Статус заказа";
            }
            catch { }
            finally { }
        }
        private void numericUpDownIDorderReturn_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int orderid = Convert.ToInt32(numericUpDownIDorderReturn.Value);
                var TakeOrder = from o in conn.Orders
                                join r in conn.Readers on o.ID_Reader equals r.ID_Reader
                                join b in conn.Books on o.ID_Book equals b.ID_Book
                                select new { o.ID_Order, b.ID_Book, b.Name, r.FirstName, r.LastName, o.Status };
                dataTableReturn.DataSource = TakeOrder.Where(c => c.ID_Order.Equals(orderid) && c.Status == "Выдана").ToList();
                dataTables.DataSource = TakeOrder.Where(c => c.ID_Order.Equals(orderid) && c.Status == "Не выдана").ToList();
                dataTableReturn.Columns[0].HeaderText = "ID заказа";
                dataTableReturn.Columns[1].HeaderText = "ID книги";
                dataTableReturn.Columns[2].HeaderText = "Название книги";
                dataTableReturn.Columns[3].HeaderText = "Имя заказчика";
                dataTableReturn.Columns[4].HeaderText = "Фамилия заказчика";
                dataTableReturn.Columns[5].HeaderText = "Статус заказа";
            }
            catch { }
            finally { }
        }

        private void AddAuthor_Click(object sender, EventArgs e)
        {
            AddAuthorForm add = new AddAuthorForm();
            add.ShowDialog();
        }

        private void bookInLibrary_Click(object sender, EventArgs e)
        {
            BooksCount booksCount = new BooksCount();
            booksCount.ShowDialog();
            
        }

        private void buttonAddGenre_Click(object sender, EventArgs e)
        {
            AddGenreForm add = new AddGenreForm();
            add.ShowDialog();
        }
    }
}
