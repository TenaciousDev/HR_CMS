using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Data
{
    public class Dept
    {
        [Key]
        public int DeptID { get; set; }

        [Required]
        public string DeptName { get; set; }

        public int PersonnelCount { get; set; }
    }
}
