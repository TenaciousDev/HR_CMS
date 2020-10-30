using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Models._03_WorkInfo
{
    public class GetWorkInfoByActive
    {
        public int WorkInfoId { get; set; }
        public int PositionId { get; set; }
        public int ContactId { get; set; }
        public decimal Wage { get; set; }
        public DateTimeOffset StartOfBenefits { get; set; }
        public string WorkEmail { get; set; }

    }
}
