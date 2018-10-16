namespace dich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class filmincinema211 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FilmInCinemas", "FilmInCinemaName", "dbo.Films");
            DropIndex("dbo.FilmInCinemas", new[] { "FilmInCinemaName" });
            DropPrimaryKey("dbo.Films");
            AlterColumn("dbo.Films", "FilmName", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.FilmInCinemas", "FilmInCinemaName", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Films", "FilmName");
            CreateIndex("dbo.FilmInCinemas", "FilmInCinemaName");
            AddForeignKey("dbo.FilmInCinemas", "FilmInCinemaName", "dbo.Films", "FilmName");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FilmInCinemas", "FilmInCinemaName", "dbo.Films");
            DropIndex("dbo.FilmInCinemas", new[] { "FilmInCinemaName" });
            DropPrimaryKey("dbo.Films");
            AlterColumn("dbo.FilmInCinemas", "FilmInCinemaName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Films", "FilmName", c => c.String(nullable: false, maxLength: 100));
            AddPrimaryKey("dbo.Films", "FilmName");
            CreateIndex("dbo.FilmInCinemas", "FilmInCinemaName");
            AddForeignKey("dbo.FilmInCinemas", "FilmInCinemaName", "dbo.Films", "FilmName");
        }
    }
}
