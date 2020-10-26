using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Data
{
    public class WorkInfo
    {

        [Key]
        public int WorkInfoId { get; set; }
        public int PersonnelId { get; set; }
        [ForeignKey(nameof(PersonnelId))]
        public virtual Personnel Personnel { get; set; }
        public int ContactId { get; set; }
        [ForeignKey(nameof(ContactId))]
        public virtual Contact Contact { get; set; }

        public int PositionId { get; set; }
        [ForeignKey(nameof(PositionId))]
        public virtual Position PositionHeld { get; set; }
        public decimal Wage { get; set; }
        public bool HasBenefits
        {
            get
            {
                if ((DateTime.Now - StartOfBenefits).TotalSeconds >= 0)
                {
                    return true;
                }
                return false;
            }
        }
        public DateTimeOffset StartOfBenefits 
        {
            get
            {
                Personnel pers = new Personnel();
                DateTimeOffset result = pers.DOH.AddDays(90);
                return result;
            }
        }
        public string WorkEmail { get; set; }
        public DateTimeOffset LastReview { get; set; }
        public DateTimeOffset NextReview //set to quarterly reviews as default
        {
            get
            {
                DateTimeOffset result = LastReview.AddDays(90);
                return result;
            }
        }
        public double VacationDaysAccruedLifetime 
        {
            //currently returns the amount of days passed since date of benefit start. Currently runs on requiring user input to determine the vacationVariable as it would be unfeasable for the programmers to determine how much vacation time the company gives its employees and it required a placeholder.
            get
            {
               
                int vacationVariable = Int32.Parse(Console.ReadLine());
                double totalDaysSinceBenefitStart = (DateTimeOffset.Now - StartOfBenefits).TotalDays;
                double accrued = totalDaysSinceBenefitStart / vacationVariable;
                return accrued;
            }
        }
        public double VacationDaysUsedLifetime 
        {
            get
            {
                int newVacationSubmission = Int32.Parse(Console.ReadLine());
                double total = VacationDaysUsedLifetime + newVacationSubmission;
                return total;
            }
        }
        public double VacationDaysAccruedForPeriod 
        {
            get
            {
                //console user input variables
                DateTimeOffset startOfPeriod =Convert.ToDateTime(Console.ReadLine());
                int vacationVariable = Int32.Parse(Console.ReadLine());
                //actual method
                double totalDaysSincePeriodStart = (DateTimeOffset.Now-startOfPeriod).TotalDays;
                double accrued = totalDaysSincePeriodStart / vacationVariable;
                return accrued;
            }
        }
        public double VacationDaysUsedForPeriod
        {
            get
            {
                int newVacationSubmission = Int32.Parse(Console.ReadLine());
                double total = VacationDaysUsedForPeriod + newVacationSubmission;
                return total;
            }
        }

        public double PersonalDaysAccruedLifetime
        {
            get
            {

                int personalVariable = Int32.Parse(Console.ReadLine());
                double totalDaysSinceBenefitStart = (DateTimeOffset.Now - StartOfBenefits).TotalDays;
                double accrued = totalDaysSinceBenefitStart / personalVariable;
                return accrued;
            }
        }
        public double PersonalDaysUsedLifetime
        {
            get
            {
                int newPersonalSubmission = Int32.Parse(Console.ReadLine());
                double total = VacationDaysUsedLifetime + newPersonalSubmission;
                return total;
            }
        }
        public double PersonalDaysAccruedForPeriod
        {
            get
            {
                //console user input variables
                DateTimeOffset startOfPeriod = Convert.ToDateTime(Console.ReadLine());
                int personalVariable = Int32.Parse(Console.ReadLine());
                //actual method
                double totalDaysSincePeriodStart = (DateTimeOffset.Now - startOfPeriod).TotalDays;
                double accrued = totalDaysSincePeriodStart / personalVariable;
                return accrued;
            }
        }

        public double PersonalDaysUsedForPeriod
        {
            get
            {
                int newPersonalSubmission = Int32.Parse(Console.ReadLine());
                double total = VacationDaysUsedForPeriod + newPersonalSubmission;
                return total;
            }
        }

        public double SickDaysAccruedLifetime
        {
            get
            {

                int diseaseVariable = Int32.Parse(Console.ReadLine());
                double totalDaysSinceBenefitStart = (DateTimeOffset.Now - StartOfBenefits).TotalDays;
                double accrued = totalDaysSinceBenefitStart / diseaseVariable;
                return accrued;
            }
        }
        public double SickDaysUsedLifetime
        {
            get
            {
                int newDiseaseSubmission = Int32.Parse(Console.ReadLine());
                double total = VacationDaysUsedLifetime + newDiseaseSubmission;
                return total;
            }
        }
        public double SickDaysAccruedForPeriod
        {
            get
            {
                //console user input variables
                DateTimeOffset startOfPeriod = Convert.ToDateTime(Console.ReadLine());
                int diseaseVariable = Int32.Parse(Console.ReadLine());
                //actual method
                double totalDaysSincePeriodStart = (DateTimeOffset.Now - startOfPeriod).TotalDays;
                double accrued = totalDaysSincePeriodStart / diseaseVariable;
                return accrued;
            }
        }
        public double SickDaysUsedForPeriod
        {
            get
            {
                int newDiseaseSubmission = Int32.Parse(Console.ReadLine());
                double total = VacationDaysUsedForPeriod + newDiseaseSubmission;
                return total;
            }
        }
    }
}
