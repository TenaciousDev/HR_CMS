using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Models
{
    public class WorkInfoEdit 
    {
        public int? PersonnelId { get; set; }
        //public int WorkInfoId { get; set; }
        public int PositionId { get; set; }
        public decimal Wage { get; set; }
        public string WorkEmail { get; set; }
        public DateTimeOffset LastReview { get; set; }
        public DateTimeOffset NextReview
        { 
            get
            {
                if (LastReview.Date.Equals(default))
                {
                    return DateTime.Now.AddDays(30);
                }
                else
                {
                    return LastReview.Date.AddDays(90);
                }
            }
        }
        public bool HasBenefits { get; set; }
        public DateTimeOffset StartOfBenefits { get; set; }
        public double VacationDaysUsedLifetime { get; set; }
        public double VacationDaysUsedForPeriod { get; set; }
        public double PersonalDaysUsedLifetime { get; set; }
        public double PersonalDaysUsedForPeriod { get; set; }
        public double SickDaysUsedLifetime { get; set; }
        public double SickDaysUsedForPeriod { get; set; }
        public double VacationDaysAccruedLifetime { get; set; }
        
        public double VacationDaysAccruedForPeriod { get; set; }
       
        public double PersonalDaysAccruedLifetime { get; set; }
        
        public double PersonalDaysAccruedForPeriod { get; set; }
        
        public double SickDaysAccruedLifetime { get; set; }
        
        public double SickDaysAccruedForPeriod { get; set; }
        
    }
}
