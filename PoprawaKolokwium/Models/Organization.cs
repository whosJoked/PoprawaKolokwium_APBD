using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PoprawaKolokwium.Models
{
    public class Organization
    {
        [Key]
        public int OrganizationId { get; set; }

        [Required]
        [MaxLength(100)]
        public string OrganizationName { get; set; }

        [Required]
        [MaxLength(50)]
        public string OrganizationDomain { get; set; }

        public ICollection<Team> Teams { get; set; }
        public ICollection<Member> Members { get; set; }
    }
}
