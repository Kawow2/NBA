using NBAAPP.Models;

namespace NBAAPP.Interface.Manager
{
    public interface IPlayerManager
    {
        void DeleteAllPlayers();
        void SaveAll(List<PlayerModel> players);
    }
}
