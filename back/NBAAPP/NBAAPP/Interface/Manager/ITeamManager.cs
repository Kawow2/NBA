using NBAAPP.Models;

namespace NBAAPP.Interface.Manager
{
    public interface ITeamManager
    {
        void SaveAll(List<TeamModel> teams);
        void DeleteAll();
        List<TeamModel> GetAll();
    }
}
