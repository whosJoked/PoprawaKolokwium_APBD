using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PoprawaKolokwium.Models
{
    public class Member
    {
        [Key]
        public int MemberId { get; set; }

        [Required]
        public int OrganizationId { get; set; }

        [Required]
        [MaxLength(20)]
        public string MemberName { get; set; }

        [Required]
        [MaxLength(50)]
        public string MemberSurname { get; set; }

        [MaxLength(20)]
        public string? MemberNickName { get; set; }

        public ICollection<Team> Teams { get; set; }

        public ICollection<Membership> Memberships { get; set; }

    }
}
