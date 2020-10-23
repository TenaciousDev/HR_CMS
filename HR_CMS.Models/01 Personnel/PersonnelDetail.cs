using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Models
{
    public class PersonnelDetail
    {
        public int PersonnelId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public int SSN { get; set; }

        public DateTimeOffset DOB { get; set; }

        public DateTimeOffset DOH { get; set; }

        public DateTimeOffset? DOT { get; set; }
    }
}
