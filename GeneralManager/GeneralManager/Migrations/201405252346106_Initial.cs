namespace GeneralManager.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Contacts", "Number", c => c.Int());
            AddColumn("dbo.Contacts", "Discriminator", c => c.String(nullable: false, maxLength: 128));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Contacts", "Discriminator");
            DropColumn("dbo.Contacts", "Number");
        }
    }
}
