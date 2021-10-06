using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace StreamingIndustry.Models
{
    public class Song
    {
        public Song()
        {
            Id = new Guid();
        }
        /* maps to primary key */
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }
        [Required]
        public int Mins { get; set; }
        [Required]
        public int Secs { get; set; }

        /* navigational property: One-to-One relationship to Genre */
        public virtual Genre Genre { get; set; }
    }
}
