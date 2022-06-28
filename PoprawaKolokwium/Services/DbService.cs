using PoprawaKolokwium.Context;
using PoprawaKolokwium.Models.DTOs;
using System.Linq;
using System.Threading.Tasks;

namespace PoprawaKolokwium.Services
{
    public class DbService : IDbService
    {
        private readonly KolDbContext _kolDbContext;

        public DbService(KolDbContext kolDbContext)
        {
            _kolDbContext = kolDbContext;
        }
        public async Task<TeamDTO> GetTeamById(int teamId)
        {
            var team = await _kolDbContext.Team.Where(o => o.TeamId == teamId).Select(o => new TeamDTO
            {
                Name = o.TeamName,
                Description = o.TeamDescription,
                Members = o.Members.Select(o => new MemberDTO
                {
                    MemberName = o.MemberName,
                }).ToList(),
                Organization = new OrganizationDTO {
                    Name = o.Organization.OrganizationName
                },
                Membership = new MembershipDTO
                {
                    MembershipDate = o.Membership.MembershipDate
                }
            });
        }
    }
}
