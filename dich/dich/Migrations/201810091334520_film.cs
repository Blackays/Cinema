namespace dich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class film : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Films", "FilmTime", c => c.Int(nullable: false));
            AlterColumn("dbo.Films", "FilmHall", c => c.Int());
            AlterColumn("dbo.Films", "FilmDay", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Films", "FilmDay", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Films", "FilmHall", c => c.Int(nullable: false));
            DropColumn("dbo.Films", "FilmTime");
        }
    }
}
