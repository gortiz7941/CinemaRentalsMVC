namespace CinemaRentals2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("Insert Into Genres (Id, Name) Values(1, 'Comedy')");
            Sql("Insert Into Genres (Id, Name) Values(2, 'New')");
            Sql("Insert Into Genres (Id, Name) Values(3, 'Romance')");
            Sql("Insert Into Genres (Id, Name) Values(4, 'Family')");
        }
        
        public override void Down()
        {
        }
    }
}
