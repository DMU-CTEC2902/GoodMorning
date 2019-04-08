using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Movie_website.Models
{
    public class User
    {
        //this class countain the following properties 
        public virtual int UserId { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Usertype { get; set; }
        public virtual Boolean IsActive { get; set; }
        public virtual string Password { get; set; }
    }
}