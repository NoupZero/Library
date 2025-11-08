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
    public partial class MainReader : Form
    {
        private int id;
        LibraryBD1 conn = new LibraryBD1();

        public MainReader(string login)
        {
            InitializeComponent();
            id = conn.Readers.SingleOrDefault(x => x.Login == login).ID_Reader;
        }

        private void CreateOrder_Click(object sender, EventArgs e)
        {
            CreateOrder createOrder = new CreateOrder(id);
            createOrder.ShowDialog();
        }

        private void MainReader_Shown(object sender, EventArgs e)
        {
            var filter = from o in conn.Orders
                         join r in conn.Readers on o.ID_Reader equals r.ID_Reader
                         where r.ID_Reader == id
                         join b in conn.Books on o.ID_Book equals b.ID_Book
                         join a in conn.Authors on b.ID_Author equals a.ID_Author
                         join g in conn.Genres on b.ID_Genre equals g.ID_Genre
                         select new { b.Name, a.FIO, g.Name_Genre, o.Date_Order, o.Date_Return, o.ID_Order };
            dataBooksOrder.DataSource = filter.ToList();
            dataBooksOrder.Columns[0].HeaderText = "Название книги";
            dataBooksOrder.Columns[1].HeaderText = "Автор";
            dataBooksOrder.Columns[2].HeaderText = "Жанр";
            dataBooksOrder.Columns[3].HeaderText = "Дата заказа";
            dataBooksOrder.Columns[4].HeaderText = "Дата возврата";
            dataBooksOrder.Columns[5].HeaderText = "ID заказа";
            string firstName = conn.Readers.SingleOrDefault(x => x.ID_Reader == id).FirstName;
            string lastName = conn.Readers.SingleOrDefault(x => x.ID_Reader == id).LastName;
            DateTime date = new DateTime();
            date = DateTime.Now;
            this.Text = firstName + " " + lastName;
            labelName.Text = firstName + " " + lastName;
            if (filter.Any(r => r.Date_Return <= date.Date))
            {
                MessageBox.Show("Верните книгу", "Предупреждение");
                
            }
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            var filter = from o in conn.Orders
                         join r in conn.Readers on o.ID_Reader equals r.ID_Reader
                         where r.ID_Reader == id
                         join b in conn.Books on o.ID_Book equals b.ID_Book
                         join a in conn.Authors on b.ID_Author equals a.ID_Author
                         join g in conn.Genres on b.ID_Genre equals g.ID_Genre
                         select new { b.Name, a.FIO, g.Name_Genre, o.Date_Order, o.Date_Return, o.ID_Order };
            dataBooksOrder.DataSource = filter.Where(f => f.Name.Contains(textBoxSearch.Text)
            || f.FIO.Contains(textBoxSearch.Text)
            || f.Name_Genre.Contains(textBoxSearch.Text)).ToList();
        }

        private void MainReader_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void MainReader_Activated(object sender, EventArgs e)
        {
            var filter = from o in conn.Orders
                         join r in conn.Readers on o.ID_Reader equals r.ID_Reader
                         where r.ID_Reader == id
                         join b in conn.Books on o.ID_Book equals b.ID_Book
                         join a in conn.Authors on b.ID_Author equals a.ID_Author
                         join g in conn.Genres on b.ID_Genre equals g.ID_Genre
                         select new { b.Name, a.FIO, g.Name_Genre, o.Date_Order, o.Date_Return, o.ID_Order };
            dataBooksOrder.DataSource = filter.ToList();
            dataBooksOrder.Columns[0].HeaderText = "Название книги";
            dataBooksOrder.Columns[1].HeaderText = "Автор";
            dataBooksOrder.Columns[2].HeaderText = "Жанр";
            dataBooksOrder.Columns[3].HeaderText = "Дата заказа";
            dataBooksOrder.Columns[4].HeaderText = "Дата возврата";
            dataBooksOrder.Columns[5].HeaderText = "ID заказа";
        }
        private void buttonProfile_Click(object sender, EventArgs e)
        {
            Account account = new Account(1,id);
            account.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
        }

        private void buttonProfile_MouseEnter(object sender, EventArgs e)
        {
            buttonProfile.BackColor = Color.LightGray;
        }

        private void buttonProfile_MouseLeave(object sender, EventArgs e)
        {
            buttonProfile.BackColor = Color.White;
        }
    }
}
