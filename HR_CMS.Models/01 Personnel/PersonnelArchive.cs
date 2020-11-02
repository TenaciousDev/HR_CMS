using System;
using System.ComponentModel.DataAnnotations;

namespace HR_CMS.Models
{
    public class PersonnelArchive
    {
        [Required]
        public int PersonnelId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string MiddleName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string SSN { get; set; }
        [Required]
        public DateTimeOffset DOB { get; set; }
        [Required]
        public DateTimeOffset DOH { get; set; }
        [Required]
        public DateTimeOffset? DOT { get; set; }
    }
}