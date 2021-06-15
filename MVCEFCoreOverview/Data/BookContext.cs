using Microsoft.EntityFrameworkCore;
using MVCEFCoreOverview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEFCoreOverview.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }

        public DbSet<Book> books { get; set; }
        public DbSet<Person> pers { get; set; }
        public DbSet<BookDetail> details { get; set; }
        public DbSet<Publisher> publishers { get; set; }

        // use this code if you don't want to use Json stirngs solution1 - int startup
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=LAPTOP-MTGLS0HR\\SQLEXPRESS;Database=BooksEF;Integrated Security=True;");
        //.\\SQLEXPRESS; you can use this server name instead of your full server name
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
