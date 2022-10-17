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
        public IEnumerable<string> Get()
        {
            GameBrowserModel game = GameBrowserModel.Instance;
            return game.GetGames();
        }

        [HttpPost]
        public void Post([FromBody]string name)
        {
            GameBrowserModel game = GameBrowserModel.Instance;
            game.NewGame(name);
            
        }
    }
}