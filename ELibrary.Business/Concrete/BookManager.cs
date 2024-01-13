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
        public List<Book> GetAll()
        {
            return _bookDal.GetAll();
        }
    }
}
