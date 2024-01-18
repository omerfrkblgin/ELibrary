using ELibrary.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Business.Abstract
{
    public interface IBookService
    {
        List<Book> GetAll();
        List<Book> GetBooksByGenre(int bookId);
        void Add(Book book);
        void Update(Book book);
        void Delete(Book book);
    }
}
