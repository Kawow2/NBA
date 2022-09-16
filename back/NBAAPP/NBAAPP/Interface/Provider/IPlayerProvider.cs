using NBAAPP.Models;

namespace NBAAPP.Interface.Provider
{
    public interface IPlayerProvider
    {
        IEnumerable<PlayerModel> GetAllPlayers();
        void Save(PlayerModel player);
    }
}
