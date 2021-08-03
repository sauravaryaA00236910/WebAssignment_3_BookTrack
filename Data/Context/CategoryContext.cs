using System;
using Microsoft.EntityFrameworkCore;

namespace WebAssignment_3_BookTrack.Data.Context
{
    public class CategoryContext
        : DbContext
    {
        public CategoryContext(DbContextOptions<CategoryContext> options)
            : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
    }
}
