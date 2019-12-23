namespace ruanj1801.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Users201911281438 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Account", c => c.String(nullable: false, maxLength: 20));
            AddColumn("dbo.Users", "Password", c => c.String(nullable: false, maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "Password");
            DropColumn("dbo.Users", "Account");
        }
    }
}
