namespace HR_CMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MoreCheckiing : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WorkInfo", "NextReview", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WorkInfo", "NextReview", c => c.DateTimeOffset(precision: 7));
        }
    }
}
