using Microsoft.EntityFrameworkCore;
using NBAAPP.Data;
using NBAAPP.Interface.Provider;
using NBAAPP.Models;

namespace NBAAPP.Provider
{
    public class PlayerProvider : IPlayerProvider
    {
        public readonly DataContext db;

        public PlayerProvider(DataContext data)
        {
            db = data;
        }

        public void DeleteAllPlayers()
        {
            db.Players.RemoveRange(db.Players);
            db.SaveChanges();

        }

        public IEnumerable<PlayerModel> GetAllPlayers()
        {
            return db.Players;
        }

        public void Save(PlayerModel player)
        {
            db.Add(player);
            db.SaveChanges();
        }
    }
}
