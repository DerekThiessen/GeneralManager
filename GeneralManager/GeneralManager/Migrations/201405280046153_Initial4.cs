namespace GeneralManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "State", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Zip", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "Phone", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Phone", c => c.String());
            AlterColumn("dbo.Contacts", "Email", c => c.String());
            AlterColumn("dbo.Contacts", "Zip", c => c.String());
            AlterColumn("dbo.Contacts", "State", c => c.String());
            AlterColumn("dbo.Contacts", "City", c => c.String());
            AlterColumn("dbo.Contacts", "Address", c => c.String());
        }
    }
}
