﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Models
{
    public class DeptCreate
    {
        [Required]
        public string DeptName { get; set; }
        public int PersonnelCount { get; set; }
    }
}
