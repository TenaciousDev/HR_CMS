using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Models
{
    public class PositionDetail
    {
        [Required]
        public int PositionId { get; set; }
        [Required]
        public string PositionTitle { get; set; }
        [Required]
        public int DeptId { get; set; } //If this causes issues, revisit whether this should be a DeptId or a Dept object

        //not required bc determined via another model
        public string DeptName { get; set; }
        [Required]
        public bool IsSupervisor { get; set; }
        [Required]
        public bool IsDirector { get; set; }
        [Required]
        public bool IsExecutive { get; set; }

    }
}
