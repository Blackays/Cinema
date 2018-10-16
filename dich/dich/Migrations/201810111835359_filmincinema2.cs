namespace dich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class filmincinema2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FilmInCinemas", "FilmInCinemaHall", c => c.String());
            AddColumn("dbo.FilmInCinemas", "FilmInCinemaDay", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.FilmInCinemas", "FilmInCinemaDay");
            DropColumn("dbo.FilmInCinemas", "FilmInCinemaHall");
        }
    }
}
