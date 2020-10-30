namespace HR_CMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedSSNToStringFromInt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Personnel", "SSN", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Personnel", "SSN", c => c.Int(nullable: false));
        }
    }
}
