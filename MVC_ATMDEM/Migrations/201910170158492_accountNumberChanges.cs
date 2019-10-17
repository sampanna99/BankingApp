namespace MVC_ATMDEM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class accountNumberChanges : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.CheckingAccounts", "AccountNumber", c => c.String(nullable: false, maxLength: 10, unicode: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.CheckingAccounts", "AccountNumber", c => c.String(nullable: false));
        }
    }
}
