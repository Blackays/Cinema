namespace dich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class filmincinema : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Films", "FilmYear");
            DropColumn("dbo.Films", "FilmHall");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Films", "FilmHall", c => c.Int());
            AddColumn("dbo.Films", "FilmYear", c => c.Int(nullable: false));
        }
    }
}
