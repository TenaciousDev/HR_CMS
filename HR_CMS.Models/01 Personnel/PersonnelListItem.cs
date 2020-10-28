using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Models
{
    public class PersonnelListItem
    {
        public int PersonnelId { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public int SSN { get; set; }

        public DateTimeOffset DOB { get; set; }

        public DateTimeOffset DOH { get; set; }

        public DateTimeOffset? DOT { get; set; }
        
        //Before, IsActive was throwing false regardless what the DOT value was (null or not). 
        //To fix this issue, I changed the property from public bool IsActive{get;set} to the code below.
        public bool IsActive
        {
            get
            {
                if (DOT == null)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
