using HR_CMS.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Models
{
    public class WorkInfoListItem
    {
        public int? PersonnelId { get; set; }
        public int WorkInfoId { get; set; }
        public int PositionId { get; set; }
        public int ContactId { get; set; }
        public decimal Wage { get; set; }
        public string WorkEmail { get; set; }
        // added to bottom for easier review
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PositionTitle { get; set; }
        public string DeptName { get; set; }
    }
}
