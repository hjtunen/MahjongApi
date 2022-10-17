using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MahjongApi.Models;

namespace MahjongApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameBrowserController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<MahjongEngine> Get()
        {
            GameModel game = GameModel.Instance;
            return game.GetGames();
        }

        [HttpPost]
        public void Post([FromBody]string player)
        {
            GameModel game = GameModel.Instance;
            game.NewGame();
            
        }
    }
}