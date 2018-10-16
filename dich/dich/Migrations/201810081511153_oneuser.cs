namespace dich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class oneuser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.UserProfiles", "UserId", "dbo.Users");
            DropIndex("dbo.UserProfiles", new[] { "UserId" });
            AddColumn("dbo.Users", "UserName", c => c.String(maxLength: 25));
            AddColumn("dbo.Users", "UserSurName", c => c.String(maxLength: 25));
            AddColumn("dbo.Users", "UserAge", c => c.Int(nullable: false));
            DropTable("dbo.UserProfiles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserProfiles",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        UserName = c.String(maxLength: 25),
                        UserSurName = c.String(maxLength: 25),
                        UserAge = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId);
            
            DropColumn("dbo.Users", "UserAge");
            DropColumn("dbo.Users", "UserSurName");
            DropColumn("dbo.Users", "UserName");
            CreateIndex("dbo.UserProfiles", "UserId");
            AddForeignKey("dbo.UserProfiles", "UserId", "dbo.Users", "UserId");
        }
    }
}
