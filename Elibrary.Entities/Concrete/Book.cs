using Elibrary.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.Entities.Concrete
{
    public class Book : IEntity
    {
        public int BookId { get; set; }
        public string Author { get; set; }
        public string BookName { get; set; }
        public string BookGenre { get; set; }
        public int BookPage { get; set; }
    }
}
