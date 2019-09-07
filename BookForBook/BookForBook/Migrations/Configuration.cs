namespace BookForBook.Migrations
{
    using BookForBook.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration// : DbMigrationsConfiguration<BookForBook.Persistance.DatabaseContext>
    {
    //    public Configuration()
    //    {
    //        AutomaticMigrationsEnabled = true;
    //        AutomaticMigrationDataLossAllowed = true;
    //    }

    //    protected override void Seed(BookForBook.Persistance.DatabaseContext context)
    //    {
    //        //  This method will be called after migrating to the latest version.

    //        //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
    //        //  to avoid creating duplicate seed data.
    //        User u = new User()
    //        {
    //            Name = "Pera",
    //            State = "Srbija",
    //            Email = "peraperic@gmail.com",
    //        };

    //        User u1 = new User()
    //        {
    //            Name = "Djole",
    //            State = "Srbija",
    //            Email = "djovakdjole@gmail.com",
    //        };
    //        context.Users.Add(u);
    //        context.Users.Add(u1);
    //        context.SaveChanges();
    //        Book b = new Book()
    //        {
    //            Title = "Book1",
    //            Artist = "Laza Lazarevic",
    //            Genre = "Horor",
    //            ReleaseDate = DateTime.Now,
    //            UserId = u.Id
    //        };
    //        Book b1 = new Book()
    //        {
    //            Title = "Book2",
    //            Artist = "Mika Mikic",
    //            Genre = "Komedija",
    //            ReleaseDate = DateTime.Now,
    //            UserId = u1.Id
    //        };

    //        Book b2 = new Book()
    //        {
    //            Title = "Book2",
    //            Artist = "Mika Mikic",
    //            Genre = "Komedija",
    //            ReleaseDate = DateTime.Now,
    //            UserId = u1.Id
    //        };
    //        context.Books.Add(b2);
    //        context.Books.Add(b);
    //        context.Books.Add(b1);
    //        context.SaveChanges();
    //    }
    }
}
