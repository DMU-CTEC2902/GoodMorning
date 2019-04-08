using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_website.Models
{
    public class MSComments
    {
        public virtual int MSCommentsId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime DateAdded { get; set; }

        public virtual MovieStar MovieStar { get; set; }
        public virtual int MovieStarId { get; set; }

        public virtual User User { get; set; }
        public virtual int UserId { get; set; }
    }
}