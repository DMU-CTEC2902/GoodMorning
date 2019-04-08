using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_website.Models
{
    public class FilmTag
    {
        public virtual int FilmTagId { get; set; }
        public virtual int FilmId { get; set; }
        public virtual int TagId { get; set; }
        public virtual Tag Tag { get; set; }
        public virtual Film Film { get; set; }

    }
}