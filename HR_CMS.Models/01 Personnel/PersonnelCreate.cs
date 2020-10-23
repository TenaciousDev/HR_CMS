using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_CMS.Models
{
    public class PersonnelCreate
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public int SSN { get; set; }

        [Required]
        public DateTimeOffset DOB { get; set; }

        [Required]
        public DateTimeOffset DOH { get; set; }

        public bool IsActive { get; set; }
    }
}
