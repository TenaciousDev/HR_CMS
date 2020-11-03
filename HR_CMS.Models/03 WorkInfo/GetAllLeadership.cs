using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Models._03_WorkInfo
{
    public class GetAllLeadership
    {
        public int WorkInfoId { get; set; }
        public int PositionId { get; set; }
        public int ContactId { get; set; }
        public int? PersonnelId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PositionTitle { get; set; }
        public string DeptName { get; set; }
        public decimal Wage { get; set; }
        public string WorkEmail { get; set; }
    }
}
