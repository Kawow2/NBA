using NBAAPP.Models;

namespace NBAAPP.Interface.Manager
{
    public interface IPlayerManager
    {
        void SaveAll(List<PlayerModel> players);
    }
}
