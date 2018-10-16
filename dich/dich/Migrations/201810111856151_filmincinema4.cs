namespace dich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class filmincinema4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FilmInCinemas", "FilmInCinemaName", c => c.String());
            DropColumn("dbo.FilmInCinemas", "FilmIdInCinema");
        }
        
        public override void Down()
        {
            AddColumn("dbo.FilmInCinemas", "FilmIdInCinema", c => c.Int());
            DropColumn("dbo.FilmInCinemas", "FilmInCinemaName");
        }
    }
}
