﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_website.Models
{
    public class Comment
    {

        public virtual int CommentId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual DateTime DateAdded { get; set; }
        public virtual int ParentCommentId { get; set; }
        public virtual int MovieStarsId { get; set; }
        public virtual int UserId { get; set; }
        public virtual MovieStars MovieStars { get; set; }
        public virtual Users Users { get; set; }

    }
}