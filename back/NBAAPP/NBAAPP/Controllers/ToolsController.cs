using Microsoft.AspNetCore.Mvc;
using NBAAPP.Interface.Manager;
using NBAAPP.Models;
using NBAAPP.Tools;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace NBAAPP.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ToolsController : ControllerBase
    {
        
        private IPlayerManager playerManager;
        private ITeamManager teamManager;

        public ToolsController(IPlayerManager playerMana, ITeamManager teamMana)
        {
            this.playerManager = playerMana;
            this.teamManager = teamMana;
        }

                
        [HttpPost]
        [Route("fillTablePlayer")]
        public async Task FillPlayersTable()
        {
            var client = new FreeAPIClient();
            playerManager.DeleteAllPlayers();
            var players = await client.GetPlayersAsync();
            var teams = teamManager.GetAll();
            foreach (var player in players)
            {
                player.TeamID = teams.FirstOrDefault(x => x.TeamName == player.Team.TeamName).ID;
            }
            playerManager.SaveAll(players);            
        }

        [HttpPost]
        [Route("fillTableTeams")]
        public async Task FillTableTeams()
        {
            var client = new FreeAPIClient();
            teamManager.DeleteAll();
            var teams = await client.GetTeamsAsync();
            teamManager.SaveAll(teams);
        }


    }
}
