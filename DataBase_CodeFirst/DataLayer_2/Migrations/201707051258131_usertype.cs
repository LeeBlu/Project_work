namespace DataLayer_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class usertype : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.RegisteredUsers", new[] { "UserType_UserTypeID" });
            CreateIndex("dbo.RegisteredUsers", "usertype_UserTypeID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.RegisteredUsers", new[] { "usertype_UserTypeID" });
            CreateIndex("dbo.RegisteredUsers", "UserType_UserTypeID");
        }
    }
}
