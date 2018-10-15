namespace dich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class films : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Films",
                c => new
                    {
                        FildId = c.Int(nullable: false, identity: true),
                        FilmName = c.String(maxLength: 100),
                        FilmYear = c.Int(nullable: false),
                        FilmDescription = c.String(),
                        FilmType = c.String(maxLength: 100),
                        FilmHall = c.Int(nullable: false),
                        FilmDay = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.FildId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Films");
        }
    }
}
