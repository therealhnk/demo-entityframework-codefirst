namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 4000),
                        LastName = c.String(maxLength: 4000),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HouseNumber = c.String(maxLength: 4000),
                        StreetName = c.String(maxLength: 4000),
                        PostalCode = c.String(maxLength: 4000),
                        Town = c.String(maxLength: 4000),
                        Country = c.String(maxLength: 4000),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.User_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Addresses", new[] { "User_Id" });
            DropForeignKey("dbo.Addresses", "User_Id", "dbo.Users");
            DropTable("dbo.Addresses");
            DropTable("dbo.Users");
        }
    }
}
