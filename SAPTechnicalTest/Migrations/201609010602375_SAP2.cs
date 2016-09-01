namespace SAPTechnicalTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SAP2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserRegistrations", "Approval", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserRegistrations", "Approval");
        }
    }
}
