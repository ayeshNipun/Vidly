namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenreTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (1, 'Action')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (2, 'Comedy')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (3, 'Family')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (4, 'Romance')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (5, 'Horrer')");
            Sql("INSERT INTO Genres (Id, GenreName) VALUES (6, 'Thriller')");
        }
        
        public override void Down()
        {
        }
    }
}
