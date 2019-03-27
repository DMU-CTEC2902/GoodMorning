using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_website.Models
{
    public class MovieStars
    {
        public virtual int  MovieStarId { get; set; }
        public virtual string Name{ get; set; }
        public virtual Boolean IsActor { get; set; }
        public virtual Boolean IsDirector { get; set; }
    }
}