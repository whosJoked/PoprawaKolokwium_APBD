using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoprawaKolokwium.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [Required]
        public int OrganizationId { get; set; }

        [Required]
        [MaxLength(50)]
        public string TeamName { get; set; }

        [MaxLength(500)]
        public string? TeamDescription { get; set; }

        [ForeignKey("OrganizationId")]
        public Organization Organization { get; set; }

        public ICollection<Member> Members { get; set; }
        public ICollection<Membership> Memberships { get; set; }
        public ICollection<File> Files { get; set; }
    }
}
