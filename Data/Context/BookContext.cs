using System;
using Microsoft.EntityFrameworkCore;

namespace WebAssignment_3_BookTrack.Data.Context
{
    public class BookContext
        :DbContext
    {
        public BookContext(DbContextOptions<BookContext> options)
            :base(options)
        { }

        public DbSet<Book> Books { get; set; }
    }
}
