namespace HR_CMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedIt : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.WorkInfo", "StartOfBenefits", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.WorkInfo", "LastReview", c => c.DateTimeOffset(precision: 7));
            AlterColumn("dbo.WorkInfo", "NextReview", c => c.DateTimeOffset(precision: 7));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WorkInfo", "NextReview", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.WorkInfo", "LastReview", c => c.DateTimeOffset(nullable: false, precision: 7));
            AlterColumn("dbo.WorkInfo", "StartOfBenefits", c => c.DateTimeOffset(nullable: false, precision: 7));
        }
    }
}
