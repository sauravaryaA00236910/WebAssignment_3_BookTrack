// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAssignment_3_BookTrack.Data.Context;

namespace WebAssignment_3_BookTrack.Migrations
{
    [DbContext(typeof(BookContext))]
    partial class BookContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("WebAssignment_3_BookTrack.Data.Book", b =>
                {
                    b.Property<string>("ISBN")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Author")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("category")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.HasKey("ISBN");

                    b.ToTable("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
