using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Movie_website.Models
{
    //public class FilmDataInitialiser
    //{
    //}
    public class FilmDataInitialiser : DropCreateDatabaseAlways<FilmContext>
    {
        protected override void Seed(FilmContext context)
        {
            //Reivew rev1 = new Reivew();
            //rev1.ReivewId = 1;
            //rev1.Title = "My first Review";
            //rev1.Comments = "good";
            //rev1.DateAdded = new DateTime(2019, 9, 18);
            //rev1.Marks = 8;
            //context.Review.Add(rev1);
            //Reivew rev2 = new Reivew();
            //rev2.ReivewId = 2;
            //rev2.Title = "My Review";
            //rev2.Comments = "Not bad";
            //rev2.DateAdded = new DateTime(2019, 10, 13);
            //rev2.Marks = 7;
            //context.Review.Add(rev2);
            //Reivew rev3 = new Reivew();
            //rev3.ReivewId = 3;
            //rev3.Title = "My Review2";
            //rev3.Comments = "Bad";
            //rev3.DateAdded = new DateTime(2019, 9, 3);
            //rev3.Marks = 1;
            //context.Review.Add(rev3);
            //Reivew rev4 = new Reivew();
            //rev4.ReivewId = 4;
            //rev4.Title = "My Review4";
            //rev4.Comments = "Excellent";
            //rev4.DateAdded = new DateTime(2019, 11, 18);
            //rev4.Marks = 9;
            //context.Review.Add(rev4);
            //Reivew rev5 = new Reivew();
            //rev5.ReivewId = 5;
            //rev5.Title = "My Review5";
            //rev5.Comments = "NotBad";
            //rev5.DateAdded = new DateTime(2019, 12, 20);
            //rev5.Marks = 5;
            //context.Review.Add(rev5);
            //Reivew rev6 = new Reivew();
            //rev5.ReivewId = 6;
            //rev6.Title = "My Review6";
            //rev6.Comments = "good";
            //rev6.DateAdded = new DateTime(2019, 12, 29);
            //rev6.Marks = 7;
            //context.Review.Add(rev5);
            Film film1 = new Film();
            film1.FilmId = 1;
            //film1.ReivewId = 1;
            film1.FilmName = "Annabelle Comes Home";
            film1.Description = "his is the third film in the Annabelle franchise which has been going since 2014 and it is the sixth film in The Conjuring franchisewhich has been going since 2013 and it is also going to be a direct sequelto the first Annabelle and not Annabelle: Creation the prequel to the film";
            film1.Language = "English";
            film1.DateReleased = new DateTime(2019, 6, 28);
            film1.Genre = "Horror";
            film1.Image = "1.jpg";
            
            //film1.Reivew = rev1;
            context.Film.Add(film1);
            Film film2 = new Film();
            film2.FilmId = 2;
            //film2.ReivewId = 2;
            film2.FilmName = "Once Upon a Time in Hollywood";
            film2.Description =" A faded television actor and his stuntdouble strive to achieve fame and success in the film industry during the final years of Hollywood'sGolden Age in 1969 Los Angeles.";
            film2.Language = "English";
            film2.DateReleased = new DateTime(2018, 8, 14);
            film2.Genre = "Comedy";
            film2.Image = "2.jpg";
            //film2.Reivew = rev2;
            context.Film.Add(film2);
            Film film3 = new Film();
            film3.FilmId = 3;
            //film3.ReivewId = 3;
            film3.FilmName = "Hellboy";
            film3.Description = " Based on the graphic novels by Mike Mignola,Hellboy, caught between the worlds of the supernatural and human,battles an ancient sorceress bent on revenge.";
            film3.Language = "English";
            film3.DateReleased = new DateTime(2018, 8, 14);
            film3.Genre = "Action";
            film3.Image = "3.jpg";
            //film3.Reivew = rev3;
            context.Film.Add(film3);
            Film film4 = new Film();
            film4.FilmId = 4;
            //film4.ReivewId = 4;
            film4.FilmName = "The Professor and the Madman";
            film4.Description = " Professor James Murray begins work compiling words for the first edition of the Oxford English Dictionary in the mid 19th century, and receives over 10,000 entries from a patient at Broadmoor Criminal Lunatic Asylum, Dr. William Minor.";
            film4.Language = "English";
            film4.DateReleased = new DateTime(2019, 03, 07);
            film4.Genre = "Biography";
            film4.Image = "4.jpg";
            //film4.Reivew = rev4;
            context.Film.Add(film4);
            Film film5 = new Film();
            film5.FilmId = 5;
            //film5.ReivewId = 5;
            film5.FilmName = "A Quiet Place";
            film5.Description = "In a post-apocalyptic world, a family is forced to live in silence while hiding from monsters with ultra-sensitive hearing.";
            film5.Language = "English";
            film5.DateReleased = new DateTime(2018, 05, 05);
            film5.Genre = "Drama";
            film5.Image = "5.jpg";
            //film5.Reivew = rev5;
            context.Film.Add(film5);
            Film film6 = new Film();
            film6.FilmId = 6;
            //film6.ReivewId = 6;
            film6.FilmName = "A Star Is Born";
            film6.Description = "A musician helps a young singer find fame as age and alcoholism send his own career into a downward spiral.";
            film6.Language = "English";
            film6.DateReleased = new DateTime(2018, 8, 03);
            film6.Genre = "Drama";
            film6.Image = "6.jpg";
            //film6.Reivew = rev6;
            context.Film.Add(film6);
            User u1 = new User();
            u1.UserName = "user1";
            u1.Password = "1234";
            u1.Usertype = "Manager";
            u1.IsActive = true;
            context.user.Add(u1);
            User u2 = new User();
            u2.UserName = "user2";
            u2.Password = "1234";
            u2.Usertype = "Manager";
            u2.IsActive = true;
            context.user.Add(u2);
            MovieStar s = new MovieStar();
            s.Name = "Emily Brobst";
            s.Image = "EmilyBrobst.jpg";
            s.IsActor = true;
            s.IsDirector = false;
            context.MovieStar.Add(s);
            MovieStar s1 = new MovieStar();
            s1.Name = "Madison Iseman";
            s1.Image = "MadisonIseman.jpg";
            s1.IsActor = true;
            s1.IsDirector = false;
            context.MovieStar.Add(s1);


            base.Seed(context);
        }
    }

}