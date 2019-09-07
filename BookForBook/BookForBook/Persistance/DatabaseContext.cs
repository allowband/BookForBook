namespace BookForBook.Persistance
{
    using BookForBook.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DatabaseContext : DbContext
    {
        // Your context has been configured to use a 'Database' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BookForBook.Persistance.Database' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Database' 
        // connection string in the application configuration file.
        public DatabaseContext()
            : base("name=Database")
        {
            Configuration.LazyLoadingEnabled = false;
            // Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, BookForBook.Migrations.Configuration>());
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}