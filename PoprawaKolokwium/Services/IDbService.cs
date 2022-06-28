using PoprawaKolokwium.Models.DTOs;
using System.Threading.Tasks;

namespace PoprawaKolokwium.Services
{
    public interface IDbService
    {
        public Task<TeamDTO> GetTeamById(int teamId);
    }
}
