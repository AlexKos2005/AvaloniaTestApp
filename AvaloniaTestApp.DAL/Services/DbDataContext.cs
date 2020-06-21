using System;
using System.Collections.Generic;
using System.Text;
using AvaloniaTestApp.Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace AvaloniaTestApp.DAL.Services
{
   public class DbDataContext : DbContext
    {
        public DbSet<Cheque> Cheques { get; set; }

        public DbDataContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=Cheques.db");

        }
    }
}
