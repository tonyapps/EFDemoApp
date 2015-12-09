using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EFDemo.Models
{
    [Table(name : "tblArtist")]
    public class Artist
    {
        public int ArtistId { get; set; }

        [Required]
        [StringLength(100, MinimumLength=2)]
        public string Name { get; set; }
        public virtual List<Album> Albums { get; set; }
        //public List<Album> Albums { get; set; }

        public Artist(int id, string name)
        {
            id = 67;
            name = "sandeep";
        }

        public Artist()
        {
        }

        public virtual ArtistDetails ArtistDetails { get; set; }
    }
}