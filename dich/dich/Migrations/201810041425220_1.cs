namespace dich.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "rights", c => c.String(maxLength: 25));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "rights");
        }
    }
}
