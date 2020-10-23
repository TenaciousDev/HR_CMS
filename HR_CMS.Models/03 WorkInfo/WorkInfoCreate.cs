﻿using System;
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
        public int PersonnelId { get; set; }
        [Required]
        public int PositionId { get; set; }
        [Required]
        public decimal Wage { get; set; }
        //not required b/c it is generated by a method
        public bool HasBenefits { get; set; }
        //not required b/c it is generated by a method
        public DateTimeOffset StartOfBenefits { get; set; }
        [Required]
        public string WorkEmail { get; set; }
    }
}
