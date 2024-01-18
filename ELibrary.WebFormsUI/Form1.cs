using ELibrary.Business.Abstract;
using ELibrary.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ELibrary.Business.Concrete;
using ELibrary.Entities.Concrete;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace ELibrary.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            _bookService = new BookManager(new EfBookDal());
        }
        private IBookService _bookService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadBooks();
            LoadGenres();
        }
        private void LoadBooks()
        {
            dgwBooks.DataSource = _bookService.GetAll();
        }
        private void LoadGenres()
        {
            cbxGenre.DataSource = _bookService.GetAll();
            cbxGenre.DisplayMember = "BookGenre";
            cbxGenre.ValueMember = "BookId";
        }

        private void cbxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwBooks.DataSource = _bookService.GetBooksByGenre(Convert.ToInt32(cbxGenre.SelectedValue));
            }
            catch
            {

            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _bookService.Add(new Book
            {
                BookName = tbxBookName.Text,
                BookGenre = tbxBookGenre.Text,
                BookPage = Convert.ToInt32(tbxPages.Text),
                Author = tbxAuthor.Text,
            });
            LoadBooks();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _bookService.Update(new Book
            {
                BookId = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value),
                BookName = tbxBookNameUpdate.Text,
                BookGenre = tbxBookGenreUpdate.Text,
                Author = tbxAuthorUpdate.Text,
                BookPage = Convert.ToInt32(tbxPagesUpdate.Text)
            });
            LoadBooks();
        }

        private void dgwBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxAuthorUpdate.Text = dgwBooks.CurrentRow.Cells[1].Value.ToString();
            tbxBookNameUpdate.Text = dgwBooks.CurrentRow.Cells[2].Value.ToString();
            tbxBookGenreUpdate.Text = dgwBooks.CurrentRow.Cells[3].Value.ToString();
            tbxPagesUpdate.Text = dgwBooks.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _bookService.Delete(new Book { BookId = Convert.ToInt32(dgwBooks.CurrentRow.Cells[0].Value) });
            LoadBooks();
        }
    }
}
