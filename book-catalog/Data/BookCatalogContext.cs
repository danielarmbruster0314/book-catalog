using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using book_catalog.Models;

namespace book_catalog.Data
{
    public class BookCatalogContext : DbContext
    {
        public BookCatalogContext (DbContextOptions<BookCatalogContext> options)
            : base(options)
        {
        }

        public DbSet<book_catalog.Models.Book> Book { get; set; } = default!;
    }
}
