using NBAAPP.Interface.Manager;
using NBAAPP.Interface.Provider;
using NBAAPP.Models;

namespace NBAAPP.Manager
{
    public class TeamManager : ITeamManager
    {
        private ITeamProvider provider;

        public TeamManager(ITeamProvider provider)
        {
            this.provider = provider;
        }
    
        public void DeleteAll()
        {
            provider.DeleteAllTeams();
        }

        public List<TeamModel> GetAll()
        {
            return provider.GetAllTeams().ToList();
        }

        public void SaveAll(List<TeamModel> teams)
        {
            foreach (var team in teams)
            {
                provider.Save(team);
                
            }
        }
    }
}
