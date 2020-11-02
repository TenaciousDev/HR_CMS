using System;
using System.ComponentModel.DataAnnotations;

namespace HR_CMS.Models
{
    public class PersonnelArchive
    {
        [Required]
        public int PersonnelId { get; set; }
        [Required]
        public DateTimeOffset? DOT { get; set; }
    }
}