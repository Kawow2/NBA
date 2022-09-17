using NBAAPP.Models;

namespace NBAAPP.Interface.Provider
{
    public interface IPlayerProvider
    {
        void DeleteAllPlayers();
        IEnumerable<PlayerModel> GetAllPlayers();
        void Save(PlayerModel player);
    }
}
