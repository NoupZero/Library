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
    public partial class BooksCount : Form
    {
        LibraryBD1 conn = new LibraryBD1();
        public BooksCount()
        {
            InitializeComponent();
            var filter = from b in conn.Books
                         join g in conn.Genres on b.ID_Genre equals g.ID_Genre
                         join a in conn.Authors on b.ID_Author equals a.ID_Author
                         select new { b.Name, g.Name_Genre, a.FIO, b.Count };
            dataTables.DataSource = filter.ToList();
            dataTables.Columns[0].HeaderText = "Название";
            dataTables.Columns[1].HeaderText = "Жанр";
            dataTables.Columns[2].HeaderText = "Автор";
            dataTables.Columns[3].HeaderText = "Кол-во";
        }
    }
}
