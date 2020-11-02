using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR_CMS.Models
{
    public class WorkInfoEdit 
    {
        [Required]
        public int? PersonnelId { get; set; }
        //public int WorkInfoId { get; set; }
        [Required]
        public int PositionId { get; set; }
        [Required]
        public decimal Wage { get; set; }
        [Required]
        public string WorkEmail { get; set; }
        public bool HasBenefits { get; set; }
        public DateTimeOffset StartOfBenefits { get; set; }
        public DateTimeOffset LastReview { get; set; }

        //not required because generated via method
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
        //Not required, because coded differently in services, if left blank during edit, results in no change. 
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
