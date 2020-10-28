﻿using HR_CMS.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Models
{
    public class WorkInfoCreate
    {
        [Required]
        public int? PersonnelId { get; set; }
        [Required]
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }
        [Required]
        public decimal Wage { get; set; }
        //generated by method, not required by user input
        public bool HasBenefits { get; set; }
        // generated by method, not required by user input
        public DateTimeOffset StartOfBenefits
        {
            get
            {
                Personnel pers = new Personnel();
                DateTimeOffset result = pers.DOH.AddDays(90);
                return result;
            }
        }
        [Required]
        public string WorkEmail { get; set; }
        [Required] //required bc right now it is not a method, service will likely input 0
        public DateTimeOffset LastReview { get; set; }
        // generated by method, not required by user input
        public DateTimeOffset NextReview { get; set; }
        // generated by method, not required by user input
        public double VacationDaysAccruedLifetime { get; set; }
        // generated by method, not required by user input
        public double VacationDaysUsedLifetime { get; set; }
        // generated by method, not required by user input
        public double VacationDaysAccruedForPeriod { get; set; }
        // generated by method, not required by user input
        public double VacationDaysUsedForPeriod { get; set; }
        // generated by method, not required by user input
        public double PersonalDaysAccruedLifetime { get; set; } // generated by method, not required by user input
        public double PersonalDaysUsedLifetime { get; set; } // generated by method, not required by user input
        public double PersonalDaysAccruedForPeriod { get; set; } // generated by method, not required by user input
        public double PersonalDaysUsedForPeriod { get; set; }
        // generated by method, not required by user input
        public double SickDaysAccruedLifetime { get; set; } // generated by method, not required by user input
        public double SickDaysUsedLifetime { get; set; } // generated by method, not required by user input
        public double SickDaysAccruedForPeriod { get; set; } // generated by method, not required by user input
        public double SickDaysUsedForPeriod { get; set; }
    }
}
