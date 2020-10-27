using HR_CMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Models
{
    public class WorkInfoDetail
    {
        public int? PersonnelId { get; set; }
        public int WorkInfoId { get; set; }
        public int PositionId { get; set; }
        public int ContactId { get; set; }
        public decimal Wage { get; set; }
        public bool HasBenefits { get; set; }
        public DateTimeOffset StartOfBenefits { get; set; }
        public string WorkEmail { get; set; }
        public double VacationDaysAccruedLifetime { get; set; }
        public double VacationDaysUsedLifetime { get; set; }
        public double VacationDaysAccruedForPeriod { get; set; }
        public double VacationDaysUsedForPeriod { get; set; }
        public double PersonalDaysAccruedLifetime { get; set; }
        public double PersonalDaysUsedLifetime { get; set; }
        public double PersonalDaysAccruedForPeriod { get; set; }
        public double PersonalDaysUsedForPeriod { get; set; }
        public double SickDaysAccruedLifetime { get; set; }
        public double SickDaysUsedLifetime { get; set; }
        public double SickDaysAccruedForPeriod { get; set; }
        public double SickDaysUsedForPeriod { get; set; }
        //added to bottom for easier review
        public virtual Position Position { get; set; }
        public virtual Contact Contact { get; set; }
        public string DeptName { get; set; }
        public string PositionTitle { get; set; }
        public bool IsSupervisor { get; set; }

        public bool IsDirector { get; set; }

        public bool IsExecutive { get; set; }
    }
}
