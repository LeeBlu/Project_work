namespace DataLayer_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newdb : DbMigration
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
                        PostalAddress = c.String(),
                        Addresstype_AddressTypeID = c.Int(),
                        sub_SurbubID = c.Int(),
                    })
                .PrimaryKey(t => t.AddressID)
                .ForeignKey("dbo.AddressTypes", t => t.Addresstype_AddressTypeID)
                .ForeignKey("dbo.Surbubs", t => t.sub_SurbubID)
                .Index(t => t.Addresstype_AddressTypeID)
                .Index(t => t.sub_SurbubID);
            
            CreateTable(
                "dbo.AddressTypes",
                c => new
                    {
                        AddressTypeID = c.Int(nullable: false, identity: true),
                        AddressTypeDecs = c.String(),
                    })
                .PrimaryKey(t => t.AddressTypeID);
            
            CreateTable(
                "dbo.Surbubs",
                c => new
                    {
                        SurbubID = c.Int(nullable: false, identity: true),
                        SuburbName = c.String(),
                        town_TownID = c.Int(),
                    })
                .PrimaryKey(t => t.SurbubID)
                .ForeignKey("dbo.Towns", t => t.town_TownID)
                .Index(t => t.town_TownID);
            
            CreateTable(
                "dbo.Towns",
                c => new
                    {
                        TownID = c.Int(nullable: false, identity: true),
                        TownName = c.String(),
                        province_ProvinceID = c.Int(),
                    })
                .PrimaryKey(t => t.TownID)
                .ForeignKey("dbo.Provinces", t => t.province_ProvinceID)
                .Index(t => t.province_ProvinceID);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        ProvinceID = c.Int(nullable: false, identity: true),
                        ProvinceName = c.String(),
                        country_CountryID = c.Int(),
                    })
                .PrimaryKey(t => t.ProvinceID)
                .ForeignKey("dbo.Countries", t => t.country_CountryID)
                .Index(t => t.country_CountryID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryID = c.Int(nullable: false, identity: true),
                        CountryName = c.String(),
                    })
                .PrimaryKey(t => t.CountryID);
            
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
                        Department_DepartmentID = c.Int(),
                        Gender_GenderID = c.Int(),
                        Status_StatusID = c.Int(),
                        UserType_UserTypeID = c.Int(),
                    })
                .PrimaryKey(t => t.RegisteredUserID)
                .ForeignKey("dbo.Departments", t => t.Department_DepartmentID)
                .ForeignKey("dbo.Genders", t => t.Gender_GenderID)
                .ForeignKey("dbo.Status", t => t.Status_StatusID)
                .ForeignKey("dbo.UserTypes", t => t.UserType_UserTypeID)
                .Index(t => t.Department_DepartmentID)
                .Index(t => t.Gender_GenderID)
                .Index(t => t.Status_StatusID)
                .Index(t => t.UserType_UserTypeID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentID = c.Int(nullable: false, identity: true),
                        DepartmentName = c.String(),
                        DepartmentDescrption = c.String(),
                    })
                .PrimaryKey(t => t.DepartmentID);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        GenderID = c.Int(nullable: false, identity: true),
                        GenderDescription = c.String(),
                    })
                .PrimaryKey(t => t.GenderID);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusID = c.Int(nullable: false, identity: true),
                        StatusDesc = c.String(),
                    })
                .PrimaryKey(t => t.StatusID);
            
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        UserTypeID = c.Int(nullable: false, identity: true),
                        UserDescribtion = c.String(),
                    })
                .PrimaryKey(t => t.UserTypeID);
            
            CreateTable(
                "dbo.RegisteredUserAddresses",
                c => new
                    {
                        RegisteredUser_RegisteredUserID = c.Int(nullable: false),
                        Address_AddressID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.RegisteredUser_RegisteredUserID, t.Address_AddressID })
                .ForeignKey("dbo.RegisteredUsers", t => t.RegisteredUser_RegisteredUserID, cascadeDelete: true)
                .ForeignKey("dbo.Addresses", t => t.Address_AddressID, cascadeDelete: true)
                .Index(t => t.RegisteredUser_RegisteredUserID)
                .Index(t => t.Address_AddressID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RegisteredUsers", "UserType_UserTypeID", "dbo.UserTypes");
            DropForeignKey("dbo.RegisteredUsers", "Status_StatusID", "dbo.Status");
            DropForeignKey("dbo.RegisteredUsers", "Gender_GenderID", "dbo.Genders");
            DropForeignKey("dbo.RegisteredUsers", "Department_DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.RegisteredUserAddresses", "Address_AddressID", "dbo.Addresses");
            DropForeignKey("dbo.RegisteredUserAddresses", "RegisteredUser_RegisteredUserID", "dbo.RegisteredUsers");
            DropForeignKey("dbo.Surbubs", "town_TownID", "dbo.Towns");
            DropForeignKey("dbo.Towns", "province_ProvinceID", "dbo.Provinces");
            DropForeignKey("dbo.Provinces", "country_CountryID", "dbo.Countries");
            DropForeignKey("dbo.Addresses", "sub_SurbubID", "dbo.Surbubs");
            DropForeignKey("dbo.Addresses", "Addresstype_AddressTypeID", "dbo.AddressTypes");
            DropIndex("dbo.RegisteredUserAddresses", new[] { "Address_AddressID" });
            DropIndex("dbo.RegisteredUserAddresses", new[] { "RegisteredUser_RegisteredUserID" });
            DropIndex("dbo.RegisteredUsers", new[] { "UserType_UserTypeID" });
            DropIndex("dbo.RegisteredUsers", new[] { "Status_StatusID" });
            DropIndex("dbo.RegisteredUsers", new[] { "Gender_GenderID" });
            DropIndex("dbo.RegisteredUsers", new[] { "Department_DepartmentID" });
            DropIndex("dbo.Provinces", new[] { "country_CountryID" });
            DropIndex("dbo.Towns", new[] { "province_ProvinceID" });
            DropIndex("dbo.Surbubs", new[] { "town_TownID" });
            DropIndex("dbo.Addresses", new[] { "sub_SurbubID" });
            DropIndex("dbo.Addresses", new[] { "Addresstype_AddressTypeID" });
            DropTable("dbo.RegisteredUserAddresses");
            DropTable("dbo.UserTypes");
            DropTable("dbo.Status");
            DropTable("dbo.Genders");
            DropTable("dbo.Departments");
            DropTable("dbo.RegisteredUsers");
            DropTable("dbo.Countries");
            DropTable("dbo.Provinces");
            DropTable("dbo.Towns");
            DropTable("dbo.Surbubs");
            DropTable("dbo.AddressTypes");
            DropTable("dbo.Addresses");
        }
    }
}
