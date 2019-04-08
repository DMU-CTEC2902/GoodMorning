using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_website.Models
{
    public class Reivew
    {
        //this class countain the following properties 
        public virtual int ReivewId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Comments { get; set; }
        public virtual DateTime DateAdded { get; set; }
        public virtual int Marks { get; set; }
        public virtual int FilmId { get; set; }
        public virtual int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual Film Film { get; set; }
    }
}