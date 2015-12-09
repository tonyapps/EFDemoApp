using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFDemo.Models
{
    public class MusicStoreDbContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        //public DbSet<Artist> Artists1 { get; set; }
        public DbSet<Album> Albums { get; set; }
    }
}