// <auto-generated />
using System;
using Journal.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Journal.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210726212418_ChangedDate")]
    partial class ChangedDate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.8");

            modelBuilder.Entity("Journals.Model.JournalModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Entry")
                        .HasColumnType("longtext");

                    b.Property<string>("EntryName")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("JournalList");
                });
#pragma warning restore 612, 618
        }
    }
}
