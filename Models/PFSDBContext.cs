using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Security.Claims;

namespace PFSAPI.Models
{
    public class PFSDBContext : DbContext
    {
        public PFSDBContext()
        {
        }

        public PFSDBContext(DbContextOptions<PFSDBContext> options) : base(options)
        {
        }

        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Session> Session { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Voucher> Voucher { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer("Server=DESKTOP-0T43KBB;Database=ShoppingDB;Trusted_Connection=True;");
            //}
        }
    }
}

