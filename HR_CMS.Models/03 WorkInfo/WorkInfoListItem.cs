using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Models
{
    public class WorkInfoListItem
    {
        public int PersonnelId { get; set; }
        public int WorkInfoId { get; set; }
        public int PositionId { get; set; }
        public decimal Wage { get; set; }
        public DateTimeOffset StartOfBenefits { get; set; }
        public string WorkEmail { get; set; }
    }
}
