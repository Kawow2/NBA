using NBAAPP.Interface.Manager;
using NBAAPP.Interface.Provider;
using NBAAPP.Models;

namespace NBAAPP.Manager
{
    public class PlayerManager : IPlayerManager
    {
        private readonly IPlayerProvider playerProvider;

        public PlayerManager(IPlayerProvider playerPro)
        {
            playerProvider = playerPro;
        }

        public void SaveAll(List<PlayerModel> players)
        {
            foreach (var player in players)
            {
                playerProvider.Save(player);
            }
        }
    }
}
