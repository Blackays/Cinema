namespace dich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class filmincinema1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FilmInCinemas",
                c => new
                    {
                        FilmInCinemaId = c.Int(nullable: false, identity: true),
                        Film_FildId = c.Int(),
                    })
                .PrimaryKey(t => t.FilmInCinemaId)
                .ForeignKey("dbo.Films", t => t.Film_FildId)
                .Index(t => t.Film_FildId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FilmInCinemas", "Film_FildId", "dbo.Films");
            DropIndex("dbo.FilmInCinemas", new[] { "Film_FildId" });
            DropTable("dbo.FilmInCinemas");
        }
    }
}
