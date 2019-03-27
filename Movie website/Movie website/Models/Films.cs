using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_website.Models
{
    public class Films
    {
        //this class countain the following properties 
        public virtual int FilmId { get; set; }
        public virtual string FilmName { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime DateReleased { get; set; }
        public virtual string Language { get; set; }
        public virtual string Genre { get; set; }

    }
}