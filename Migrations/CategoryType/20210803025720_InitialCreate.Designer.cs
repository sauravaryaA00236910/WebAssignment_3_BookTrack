// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebAssignment_3_BookTrack.Data.Context;

namespace WebAssignment_3_BookTrack.Migrations.CategoryType
{
    [DbContext(typeof(CategoryTypeContext))]
    [Migration("20210803025720_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("WebAssignment_3_BookTrack.Data.CategoryType", b =>
                {
                    b.Property<string>("Type")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("TEXT");

                    b.HasKey("Type");

                    b.ToTable("CategoryTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
