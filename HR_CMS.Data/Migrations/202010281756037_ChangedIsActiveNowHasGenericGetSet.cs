namespace HR_CMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedIsActiveNowHasGenericGetSet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Personnel", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Personnel", "IsActive");
        }
    }
}
