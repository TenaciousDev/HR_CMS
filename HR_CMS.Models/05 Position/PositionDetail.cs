using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_CMS.Data;

namespace HR_CMS.Models
{
    public class PositionDetail
    {
        public int PositionId { get; set; }
        public string PositionTitle { get; set; }
        public int DeptId { get; set; } //If this causes issues, revisit whether this should be a DeptId or a Dept object
        public string DeptName  { get; set; }
        public bool IsSupervisor { get; set; }
        public bool IsDirector { get; set; }
        public bool IsExecutive { get; set; }

    }
}
