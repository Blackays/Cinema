namespace dich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class unique : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Users", "UserLogin", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Users", new[] { "UserLogin" });
        }
    }
}
