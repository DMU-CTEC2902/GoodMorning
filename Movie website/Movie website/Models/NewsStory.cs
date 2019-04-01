using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_website.Models
{
    public class NewsStory
    {
        //this class countain the following properties 
        public virtual int NewsStoryId { get; set; }
        public virtual string StoryTitle { get; set; }
        public virtual string ShortDesc { get; set; }
        public virtual string StoryLink { get; set; }
        public virtual DateTime DateAdded { get; set; }
        public virtual int FilmId { get; set; }
       public virtual Film Film { get; set; }
    }
}