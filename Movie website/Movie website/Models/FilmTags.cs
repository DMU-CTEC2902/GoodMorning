using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_website.Models
{
    public class FilmTags
    {
        public virtual int FilmTagId { get; set; }
        public virtual int FilmId { get; set; }
        public virtual Tags TagId { get; set; }

    }
}