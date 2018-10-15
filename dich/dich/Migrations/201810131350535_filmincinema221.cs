namespace dich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class filmincinema221 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.FilmInCinemas", "FildId", "dbo.Films");
            DropIndex("dbo.FilmInCinemas", new[] { "FildId" });
            AlterColumn("dbo.FilmInCinemas", "FildId", c => c.Int());
            CreateIndex("dbo.FilmInCinemas", "FildId");
            AddForeignKey("dbo.FilmInCinemas", "FildId", "dbo.Films", "FildId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FilmInCinemas", "FildId", "dbo.Films");
            DropIndex("dbo.FilmInCinemas", new[] { "FildId" });
            AlterColumn("dbo.FilmInCinemas", "FildId", c => c.Int(nullable: false));
            CreateIndex("dbo.FilmInCinemas", "FildId");
            AddForeignKey("dbo.FilmInCinemas", "FildId", "dbo.Films", "FildId", cascadeDelete: true);
        }
    }
}
