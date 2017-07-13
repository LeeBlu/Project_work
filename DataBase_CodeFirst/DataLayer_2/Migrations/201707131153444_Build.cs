namespace DataLayer_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Build : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressID = c.Int(nullable: false, identity: true),
                        UnitNumber = c.String(),
                        StreetName = c.String(),
                        ComplexNumber = c.String(),
                        SurbubID = c.Int(nullable: false),
                        RegisteredUserID = c.Int(nullable: false),
                        AddressTypeID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.AddressTypes", t => t.AddressTypeID, cascadeDelete: true)
                .ForeignKey("dbo.RegisteredUsers", t => t.RegisteredUserID, cascadeDelete: true)
                .ForeignKey("dbo.Surbubs", t => t.SurbubID, cascadeDelete: true)
                .Index(t => t.SurbubID)
                .Index(t => t.RegisteredUserID)
                .Index(t => t.AddressTypeID);
            
            CreateTable(
                "dbo.AddressTypes",
                c => new
                    {
                        AddressTypeID = c.Int(nullable: false, identity: true),
                        AddressTypeDecs = c.String(),
                        AddressID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AddressTypeID);
            
            CreateTable(
                "dbo.RegisteredUsers",
                c => new
                    {
                        RegisteredUserID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        EmailAddress = c.String(),
                        Password = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        DepartmentID = c.Int(nullable: false),
                        GenderID = c.Int(nullable: false),
                        StatusID = c.Int(nullable: false),
                        UserTypeID = c.Int(nullable: false),
                        AddressID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RegisteredUserID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID, cascadeDelete: true)
                .ForeignKey("dbo.Genders", t => t.GenderID, cascadeDelete: true)
                .ForeignKey("dbo.Status", t => t.StatusID, cascadeDelete: true)
                .ForeignKey("dbo.UserTypes", t => t.UserTypeID, cascadeDelete: true)
                .Index(t => t.DepartmentID)
                .Index(t => t.GenderID)
                .Index(t => t.StatusID)
                .Index(t => t.UserTypeID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                        DepartmentDescrption = c.String(),
                        RegisteredUserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        GenderID = c.Int(nullable: false, identity: true),
                        GenderDescription = c.String(),
                        RegisteredUserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.GenderID);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusID = c.Int(nullable: false, identity: true),
                        StatusDesc = c.String(),
                        RegisteredUserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StatusID);
            
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        UserTypeID = c.Int(nullable: false, identity: true),
                        UserDescribtion = c.String(),
                        RegisteredUserID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserTypeID);
            
            CreateTable(
                "dbo.Surbubs",
                c => new
                    {
                        SurbubID = c.Int(nullable: false, identity: true),
                        SuburbName = c.String(),
                        TownID = c.Int(nullable: false),
                        AddressID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SurbubID)
                .ForeignKey("dbo.Towns", t => t.TownID, cascadeDelete: true)
                .Index(t => t.TownID);
            
            CreateTable(
                "dbo.Towns",
                c => new
                    {
                        TownID = c.Int(nullable: false, identity: true),
                        TownName = c.String(),
                        ProvinceID = c.Int(nullable: false),
                        SurbubID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TownID)
                .ForeignKey("dbo.Provinces", t => t.ProvinceID, cascadeDelete: true)
                .Index(t => t.ProvinceID);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ProvinceID = c.Int(nullable: false, identity: true),
                        ProvinceName = c.String(),
                        CountryID = c.Int(nullable: false),
                        TownID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProvinceID)
                .ForeignKey("dbo.Countries", t => t.CountryID, cascadeDelete: true)
                .Index(t => t.CountryID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryID = c.Int(nullable: false, identity: true),
                        CountryName = c.String(),
                        ProvinceID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CountryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Surbubs", "TownID", "dbo.Towns");
            DropForeignKey("dbo.Towns", "ProvinceID", "dbo.Provinces");
            DropForeignKey("dbo.Provinces", "CountryID", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "SurbubID", "dbo.Surbubs");
            DropForeignKey("dbo.RegisteredUsers", "UserTypeID", "dbo.UserTypes");
            DropForeignKey("dbo.RegisteredUsers", "StatusID", "dbo.Status");
            DropForeignKey("dbo.RegisteredUsers", "GenderID", "dbo.Genders");
            DropForeignKey("dbo.RegisteredUsers", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.Addresses", "RegisteredUserID", "dbo.RegisteredUsers");
            DropForeignKey("dbo.Addresses", "AddressTypeID", "dbo.AddressTypes");
            DropIndex("dbo.Provinces", new[] { "CountryID" });
            DropIndex("dbo.Towns", new[] { "ProvinceID" });
            DropIndex("dbo.Surbubs", new[] { "TownID" });
            DropIndex("dbo.RegisteredUsers", new[] { "UserTypeID" });
            DropIndex("dbo.RegisteredUsers", new[] { "StatusID" });
            DropIndex("dbo.RegisteredUsers", new[] { "GenderID" });
            DropIndex("dbo.RegisteredUsers", new[] { "DepartmentID" });
            DropIndex("dbo.Addresses", new[] { "AddressTypeID" });
            DropIndex("dbo.Addresses", new[] { "RegisteredUserID" });
            DropIndex("dbo.Addresses", new[] { "SurbubID" });
            DropTable("dbo.Countries");
            DropTable("dbo.Provinces");
            DropTable("dbo.Towns");
            DropTable("dbo.Surbubs");
            DropTable("dbo.UserTypes");
            DropTable("dbo.Status");
            DropTable("dbo.Genders");
            DropTable("dbo.Departments");
            DropTable("dbo.RegisteredUsers");
            DropTable("dbo.AddressTypes");
            DropTable("dbo.Addresses");
        }
    }
}
