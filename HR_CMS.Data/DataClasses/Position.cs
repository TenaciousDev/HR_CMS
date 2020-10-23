using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Data
{
    public class Position
    {
        [Key]
        public int PositionId { get; set; }

        [Required]
        public string PositionTitle { get; set; }

        public int DeptId { get; set; }
        [ForeignKey(nameof(DeptId))]
        public virtual Dept Department { get; set; }

        public bool IsSupervisor { get; set; }

        public bool IsDirector { get; set; }

        public bool IsExecutive { get; set; }
    }
}
