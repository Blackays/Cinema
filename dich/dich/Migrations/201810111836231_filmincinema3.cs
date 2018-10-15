namespace dich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class filmincinema3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.FilmInCinemas", "FilmIdInCinema", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.FilmInCinemas", "FilmIdInCinema");
        }
    }
}
