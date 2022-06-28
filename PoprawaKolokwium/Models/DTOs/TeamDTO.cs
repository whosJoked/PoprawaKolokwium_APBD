using System.Collections.Generic;

namespace PoprawaKolokwium.Models.DTOs
{
    public class TeamDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<MemberDTO> Members { get; set; }
        public OrganizationDTO Organization { get; set; }
        public MembershipDTO Membership { get; set; }
    }
}
