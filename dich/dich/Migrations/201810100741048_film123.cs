namespace dich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class film123 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Films", "FilmDay", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        public override void Down()
        {
            AlterColumn("dbo.Films", "FilmDay", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
    }
}
