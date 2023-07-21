namespace Autentication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class creatdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TUser",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Family = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 100),
                        MobileNumber = c.String(nullable: false, maxLength: 13),
                        IsActive = c.Boolean(nullable: false),
                        RegisterDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.TUser");
        }
    }
}
