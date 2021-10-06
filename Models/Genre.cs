using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace StreamingIndustry.Models
{
    public class Genre
    {

            public Genre()
            {
                Id = new Guid();
            }
            /* maps to primary key */
            public Guid Id { get; set; }

            [Required]
            public string Name { get; set; }

            /* navigational property: One-to-One relationship to Genre */
            public virtual ICollection<Song> Songs { get; set; }
        
    }
}
