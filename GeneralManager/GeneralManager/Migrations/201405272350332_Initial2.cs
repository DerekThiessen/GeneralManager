namespace GeneralManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Contacts", "LastName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "LastName", c => c.String());
            AlterColumn("dbo.Contacts", "FirstName", c => c.String());
        }
    }
}
