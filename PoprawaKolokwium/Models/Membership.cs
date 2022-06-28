using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PoprawaKolokwium.Models
{
    public class Membership
    {
        [Key, Column(Order = 0)]
        public int MemberId { get; set; }

        [Key, Column(Order = 1)]
        public int TeamId { get; set; }
        public DateTime MembershipDate { get; set; }

        [ForeignKey("MemberId")]
        public Member Member { get; set; }

        [ForeignKey("TeamId")]
        public Team Team { get; set; }
    }
}
