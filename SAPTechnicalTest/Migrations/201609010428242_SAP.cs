namespace SAPTechnicalTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SAP : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserRegistrations",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        LoginID = c.String(maxLength: 50),
                        UserGroup = c.String(),
                        Organisation = c.String(),
                        Department = c.String(),
                        Email = c.String(),
                        ContactNo = c.String(),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserRegistrations");
        }
    }
}
