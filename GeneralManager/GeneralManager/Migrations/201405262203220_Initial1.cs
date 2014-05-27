namespace GeneralManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "Phone", c => c.String());
            DropColumn("dbo.Contacts", "Twitter");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Contacts", "Twitter", c => c.String());
            DropColumn("dbo.Contacts", "Phone");
        }
    }
}
