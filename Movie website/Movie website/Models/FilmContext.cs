using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Movie_website.Models;

namespace Movie_website.Models
{
    public class FilmContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public FilmContext() : base("name=FilmContext")
        {
        }

        //public System.Data.Entity.DbSet<Movie_website.Models.Film> Films { get; set; }
        public DbSet<Film> Film { get; set; }
        public DbSet<Reivew> Reviews { get; set; }
        public DbSet<MovieStar> MovieStar { get; set; }
        public DbSet<MSComments> comments { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<User> user { get; set; }
        



    }
}
