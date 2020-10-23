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
        public int PersonnelId { get; set; }
        public int PositionId { get; set; }
        public decimal Wage { get; set; }
        public bool HasBenefits { get; set; }
        public DateTimeOffset StartOfBenefits { get; set; }
        public string WorkEmail { get; set; }
    }
}
