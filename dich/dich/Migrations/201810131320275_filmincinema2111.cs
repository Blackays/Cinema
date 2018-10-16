namespace dich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class filmincinema2111 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FilmInCinemas", "FilmInCinemaName", "dbo.Films");
            DropIndex("dbo.FilmInCinemas", new[] { "FilmInCinemaName" });
            DropPrimaryKey("dbo.Films");
            AddColumn("dbo.FilmInCinemas", "FildId", c => c.Int(nullable: false));
            AlterColumn("dbo.Films", "FilmName", c => c.String());
            AlterColumn("dbo.Films", "FildId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.FilmInCinemas", "FilmInCinemaName", c => c.String());
            AddPrimaryKey("dbo.Films", "FildId");
            CreateIndex("dbo.FilmInCinemas", "FildId");
            AddForeignKey("dbo.FilmInCinemas", "FildId", "dbo.Films", "FildId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FilmInCinemas", "FildId", "dbo.Films");
            DropIndex("dbo.FilmInCinemas", new[] { "FildId" });
            DropPrimaryKey("dbo.Films");
            AlterColumn("dbo.FilmInCinemas", "FilmInCinemaName", c => c.String(maxLength: 128));
            AlterColumn("dbo.Films", "FildId", c => c.Int(nullable: false));
            AlterColumn("dbo.Films", "FilmName", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.FilmInCinemas", "FildId");
            AddPrimaryKey("dbo.Films", "FilmName");
            CreateIndex("dbo.FilmInCinemas", "FilmInCinemaName");
            AddForeignKey("dbo.FilmInCinemas", "FilmInCinemaName", "dbo.Films", "FilmName");
        }
    }
}
