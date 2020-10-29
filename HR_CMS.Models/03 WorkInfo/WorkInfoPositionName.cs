using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Models._03_WorkInfo
{
    public class WorkInfoPositionName
    {
        public string PositionTitle { get; set; }
        public bool IsSupervisor { get; set; }

        public bool IsDirector { get; set; }

        public bool IsExecutive { get; set; }
    }
}
