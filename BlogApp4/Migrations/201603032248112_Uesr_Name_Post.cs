namespace BlogApp4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Uesr_Name_Post : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "User_Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "User_Name");
        }
    }
}
