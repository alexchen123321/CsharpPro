using System;
using Microsoft.EntityFrameworkCore;

namespace StreamingIndustry.Models
{
    public class DBContext: DbContext
    {
        public DBContext(DbContextOptions<DBContext> options) :base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder model)
        {
        }

        public DbSet<Song> Songs { get; set; }
        public DbSet<Genre> Genres { get; set; }

    }
}
