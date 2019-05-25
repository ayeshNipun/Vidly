namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changePropsOfMovieClass4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "ReleasedDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "ReleasedDate", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
    }
}
