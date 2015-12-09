using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EFDemo.Models
{
    public class MusicStoreDbContextInitializer : DropCreateDatabaseAlways<MusicStoreDbContext>
    {
        protected override void Seed(MusicStoreDbContext context)
        {
            Artist artist = new Artist() { Name = "First Artist" };
            context.Artists.Add(artist);

            Artist artist1 = new Artist(67, "sandeep");
            context.Artists.Add(artist1);


            context.Albums.Add(new Album() { Artist = artist, Title = "First Album" });
            context.Albums.Add(new Album() { Artist = artist, Title = "Second Album" });

            context.Albums.Add(new Album()
            {
                Artist = context.Artists.Add(new Artist() { Name = "Second Artist"}),
                Title = "Third Album"
            });

            context.Artists.Add(new SoloArtist() { Name = "Solo Artist", Instrument = "Guitar" });

            context.SaveChanges();
        }
    }
}