﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace EFDemo.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int ArtistID { get; set; }
        public virtual Artist Artist { get; set; }
        //public Artist Artist { get; set; }

        public virtual List<Reviewer> Reviewers { get; set; }
    }

    //public class MusicContext : DbContext
    //{
    //    public MusicContext()
    //    {
    //        Database.Log = s => Debug.WriteLine(s);
    //    }
    //    public DbSet<Album> Albums { get; set; }
    //}
}