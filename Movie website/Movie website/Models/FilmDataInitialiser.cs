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
            Reivew rev1 = new Reivew();
            rev1.ReivewId = 1;
            rev1.Title = "My first Review";
            rev1.Comments = "good";
            rev1.DateAdded = new DateTime(2019, 9, 18);
            rev1.Marks = 8;
            context.Review.Add(rev1);
            Reivew rev2 = new Reivew();
            rev2.ReivewId = 2;
            rev2.Title = "My Review";
            rev2.Comments = "Not bad";
            rev2.DateAdded = new DateTime(2019, 10, 13);
            rev2.Marks = 7;
            context.Review.Add(rev2);
            Reivew rev3 = new Reivew();
            rev3.ReivewId = 3;
            rev3.Title = "My Review2";
            rev3.Comments = "Bad";
            rev3.DateAdded = new DateTime(2019, 9, 3);
            rev3.Marks = 1;
            context.Review.Add(rev3);
            Reivew rev4 = new Reivew();
            rev4.ReivewId = 4;
            rev4.Title = "My Review4";
            rev4.Comments = "Excellent";
            rev4.DateAdded = new DateTime(2019, 11, 18);
            rev4.Marks = 9;
            context.Review.Add(rev4);
            Reivew rev5 = new Reivew();
            rev5.ReivewId = 5;
            rev5.Title = "My Review5";
            rev5.Comments = "NotBad";
            rev5.DateAdded = new DateTime(2019, 12, 20);
            rev5.Marks = 5;
            context.Review.Add(rev5);
            Reivew rev6 = new Reivew();
            rev5.ReivewId = 6;
            rev6.Title = "My Review6";
            rev6.Comments = "good";
            rev6.DateAdded = new DateTime(2019, 12, 29);
            rev6.Marks = 7;
            context.Review.Add(rev5);
            Film fillm1 = new Film();
            fillm1.FilmId = 1;
            fillm1.ReivewId = 1;
            fillm1.FilmName = "Annabelle Comes Home";
            fillm1.Description = "his is the third film in the Annabelle franchise which has been going since 2014 and it is the sixth film in The Conjuring franchisewhich has been going since 2013 and it is also going to be a direct sequelto the first Annabelle and not Annabelle: Creation the prequel to the film";
            fillm1.Language = "English";
            fillm1.DateReleased = new DateTime(2019, 6, 28);
            fillm1.Genre = "Horror";
            fillm1.Image = "";
            fillm1.Reivew = rev1;
            context.Film.Add(fillm1);
            Film fillm2 = new Film();
            fillm2.FilmId = 2;
            fillm2.ReivewId = 2;
            fillm2.FilmName = "Once Upon a Time in Hollywood";
            fillm2.Description =" A faded television actor and his stuntdouble strive to achieve fame and success in the film industry during the final years of Hollywood'sGolden Age in 1969 Los Angeles.";
            fillm2.Language = "English";
            fillm2.DateReleased = new DateTime(2018, 8, 14);
            fillm2.Genre = "Comedy";
            fillm2.Image = "";
            fillm2.Reivew = rev2;
            context.Film.Add(fillm2);
            Film fillm3 = new Film();
            fillm3.FilmId = 3;
            fillm3.ReivewId = 3;
            fillm3.FilmName = "Hellboy";
            fillm3.Description = " Based on the graphic novels by Mike Mignola,Hellboy, caught between the worlds of the supernatural and human,battles an ancient sorceress bent on revenge.";
            fillm3.Language = "English";
            fillm3.DateReleased = new DateTime(2018, 8, 14);
            fillm3.Genre = "Action";
            fillm3.Image = "";
            fillm3.Reivew = rev3;
            context.Film.Add(fillm3);
            Film fillm4 = new Film();
            fillm4.FilmId = 4;
            fillm4.ReivewId = 4;
            fillm4.FilmName = "The Professor and the Madman";
            fillm4.Description = " Professor James Murray begins work compiling words for the first edition of the Oxford English Dictionary in the mid 19th century, and receives over 10,000 entries from a patient at Broadmoor Criminal Lunatic Asylum, Dr. William Minor.";
            fillm4.Language = "English";
            fillm4.DateReleased = new DateTime(2019, 03, 07);
            fillm4.Genre = "Biography";
            fillm4.Image = "";
            fillm4.Reivew = rev4;
            context.Film.Add(fillm4);
            Film fillm5 = new Film();
            fillm5.FilmId = 5;
            fillm5.ReivewId = 5;
            fillm5.FilmName = "A Quiet Place";
            fillm5.Description = "In a post-apocalyptic world, a family is forced to live in silence while hiding from monsters with ultra-sensitive hearing.";
            fillm5.Language = "English";
            fillm5.DateReleased = new DateTime(2018, 05, 05);
            fillm5.Genre = "Drama";
            fillm5.Image = "";
            fillm5.Reivew = rev5;
            context.Film.Add(fillm5);
            Film fillm6 = new Film();
            fillm6.FilmId = 6;
            fillm6.ReivewId = 6;
            fillm6.FilmName = "A Star Is Born";
            fillm6.Description = "A musician helps a young singer find fame as age and alcoholism send his own career into a downward spiral.";
            fillm6.Language = "English";
            fillm6.DateReleased = new DateTime(2018, 8, 03);
            fillm6.Genre = "Drama";
            fillm6.Image = "";
            fillm6.Reivew = rev6;
            context.Film.Add(fillm6);

            base.Seed(context);
        }
    }

}