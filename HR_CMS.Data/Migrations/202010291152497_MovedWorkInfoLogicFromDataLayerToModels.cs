namespace HR_CMS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MovedWorkInfoLogicFromDataLayerToModels : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.WorkInfo", "HasBenefits", c => c.Boolean(nullable: false));
            AddColumn("dbo.WorkInfo", "StartOfBenefits", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.WorkInfo", "NextReview", c => c.DateTimeOffset(nullable: false, precision: 7));
            AddColumn("dbo.WorkInfo", "VacationDaysAccruedLifetime", c => c.Double(nullable: false));
            AddColumn("dbo.WorkInfo", "VacationDaysUsedLifetime", c => c.Double(nullable: false));
            AddColumn("dbo.WorkInfo", "VacationDaysAccruedForPeriod", c => c.Double(nullable: false));
            AddColumn("dbo.WorkInfo", "VacationDaysUsedForPeriod", c => c.Double(nullable: false));
            AddColumn("dbo.WorkInfo", "PersonalDaysAccruedLifetime", c => c.Double(nullable: false));
            AddColumn("dbo.WorkInfo", "PersonalDaysUsedLifetime", c => c.Double(nullable: false));
            AddColumn("dbo.WorkInfo", "PersonalDaysAccruedForPeriod", c => c.Double(nullable: false));
            AddColumn("dbo.WorkInfo", "PersonalDaysUsedForPeriod", c => c.Double(nullable: false));
            AddColumn("dbo.WorkInfo", "SickDaysAccruedLifetime", c => c.Double(nullable: false));
            AddColumn("dbo.WorkInfo", "SickDaysUsedLifetime", c => c.Double(nullable: false));
            AddColumn("dbo.WorkInfo", "SickDaysAccruedForPeriod", c => c.Double(nullable: false));
            AddColumn("dbo.WorkInfo", "SickDaysUsedForPeriod", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WorkInfo", "SickDaysUsedForPeriod");
            DropColumn("dbo.WorkInfo", "SickDaysAccruedForPeriod");
            DropColumn("dbo.WorkInfo", "SickDaysUsedLifetime");
            DropColumn("dbo.WorkInfo", "SickDaysAccruedLifetime");
            DropColumn("dbo.WorkInfo", "PersonalDaysUsedForPeriod");
            DropColumn("dbo.WorkInfo", "PersonalDaysAccruedForPeriod");
            DropColumn("dbo.WorkInfo", "PersonalDaysUsedLifetime");
            DropColumn("dbo.WorkInfo", "PersonalDaysAccruedLifetime");
            DropColumn("dbo.WorkInfo", "VacationDaysUsedForPeriod");
            DropColumn("dbo.WorkInfo", "VacationDaysAccruedForPeriod");
            DropColumn("dbo.WorkInfo", "VacationDaysUsedLifetime");
            DropColumn("dbo.WorkInfo", "VacationDaysAccruedLifetime");
            DropColumn("dbo.WorkInfo", "NextReview");
            DropColumn("dbo.WorkInfo", "StartOfBenefits");
            DropColumn("dbo.WorkInfo", "HasBenefits");
        }
    }
}
