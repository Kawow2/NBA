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

        public ToolsController(IPlayerManager playerMana)
        {
            this.playerManager = playerMana;
        }

                
        [HttpGet]
        public async Task FillPlayersTable()
        {
            var client = new FreeAPIClient();
            var players = await client.GetPlayersAsync();
            playerManager.SaveAll(players);

            
        }
    }
}
