using ELibrary.Business.Abstract;
using ELibrary.DataAccess.Abstract;
using ELibrary.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Business.Concrete
{
    public class BookManager : IBookService
    {
        public IBookDal _bookDal;
        public BookManager(IBookDal bookDal) 
        {
            _bookDal = bookDal; 
        }

        public void Add(Book book)
        {
            _bookDal.Add(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }

        public List<Book> GetBooksByGenre(int bookId)
        {
            return _bookDal.GetAll(p=>p.BookId == bookId);
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}
