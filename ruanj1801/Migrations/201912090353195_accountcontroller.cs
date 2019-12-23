namespace ruanj1801.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class accountcontroller : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CourseManagements", "ClassId", c => c.Int());
            AlterColumn("dbo.CourseManagements", "CourseId", c => c.Int());
            AlterColumn("dbo.CourseManagements", "TeacherId", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CourseManagements", "TeacherId", c => c.Int(nullable: false));
            AlterColumn("dbo.CourseManagements", "CourseId", c => c.Int(nullable: false));
            AlterColumn("dbo.CourseManagements", "ClassId", c => c.Int(nullable: false));
        }
    }
}
