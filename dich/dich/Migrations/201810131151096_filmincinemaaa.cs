namespace dich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class filmincinemaaa : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FilmInCinemas", "Film_FildId", "dbo.Films");
            DropIndex("dbo.FilmInCinemas", new[] { "Film_FildId" });
            DropColumn("dbo.FilmInCinemas", "FilmInCinemaName");
            RenameColumn(table: "dbo.FilmInCinemas", name: "Film_FildId", newName: "FilmInCinemaName");
            DropPrimaryKey("dbo.Films");
            AlterColumn("dbo.Films", "FildId", c => c.Int(nullable: false));
            AlterColumn("dbo.Films", "FilmName", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.FilmInCinemas", "FilmInCinemaName", c => c.String(maxLength: 100));
            AlterColumn("dbo.FilmInCinemas", "FilmInCinemaName", c => c.String(maxLength: 100));
            AddPrimaryKey("dbo.Films", "FilmName");
            CreateIndex("dbo.FilmInCinemas", "FilmInCinemaName");
            AddForeignKey("dbo.FilmInCinemas", "FilmInCinemaName", "dbo.Films", "FilmName");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FilmInCinemas", "FilmInCinemaName", "dbo.Films");
            DropIndex("dbo.FilmInCinemas", new[] { "FilmInCinemaName" });
            DropPrimaryKey("dbo.Films");
            AlterColumn("dbo.FilmInCinemas", "FilmInCinemaName", c => c.Int());
            AlterColumn("dbo.FilmInCinemas", "FilmInCinemaName", c => c.String());
            AlterColumn("dbo.Films", "FilmName", c => c.String(maxLength: 100));
            AlterColumn("dbo.Films", "FildId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Films", "FildId");
            RenameColumn(table: "dbo.FilmInCinemas", name: "FilmInCinemaName", newName: "Film_FildId");
            AddColumn("dbo.FilmInCinemas", "FilmInCinemaName", c => c.String());
            CreateIndex("dbo.FilmInCinemas", "Film_FildId");
            AddForeignKey("dbo.FilmInCinemas", "Film_FildId", "dbo.Films", "FildId");
        }
    }
}
