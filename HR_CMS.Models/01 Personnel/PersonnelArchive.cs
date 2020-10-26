using System;

namespace HR_CMS.Models
{
    public class PersonnelArchive
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