using System;
using Microsoft.EntityFrameworkCore;

namespace WebAssignment_3_BookTrack.Data.Context
{
    public class CategoryTypeContext
        : DbContext
    {
        public CategoryTypeContext(DbContextOptions<CategoryTypeContext> options)
            : base(options)
        { }

        public DbSet<CategoryType> CategoryTypes { get; set; }
    }
}
