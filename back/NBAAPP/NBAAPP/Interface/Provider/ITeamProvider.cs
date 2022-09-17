using NBAAPP.Models;

namespace NBAAPP.Interface.Provider
{
    public interface ITeamProvider
    {
        void DeleteAllTeams();
        IEnumerable<TeamModel> GetAllTeams();
        void Save(TeamModel team);
    }
}
