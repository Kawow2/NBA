using NBAAPP.Data;
using NBAAPP.Interface.Provider;
using NBAAPP.Models;

namespace NBAAPP.Provider
{
    public class TeamProvider : ITeamProvider
    {

        public readonly DataContext db;

        public TeamProvider(DataContext data)
        {
            db = data;
        }

        public void DeleteAllTeams()
        {
            db.Teams.RemoveRange(db.Teams);
            db.SaveChanges();
        }

        public IEnumerable<TeamModel> GetAllTeams()
        {
            return db.Teams.ToList();
        }

        public void Save(TeamModel team)
        {
            db.Teams.Add(team);
            db.SaveChanges();

        }
    }
}
