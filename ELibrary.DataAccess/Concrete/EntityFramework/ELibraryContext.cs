﻿using ELibrary.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELibrary.DataAccess.Concrete.EntityFramework
{
    public class ELibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}
