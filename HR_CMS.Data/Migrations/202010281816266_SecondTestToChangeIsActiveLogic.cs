namespace HR_CMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondTestToChangeIsActiveLogic : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Personnel", "IsActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Personnel", "IsActive", c => c.Boolean(nullable: false));
        }
    }
}
