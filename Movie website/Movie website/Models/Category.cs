using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_website.Models
{
    public class Category
    {
        public virtual int CategoryId { get; set; }
        public virtual int TagId { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Tag Tag { get; set; }

    }
}