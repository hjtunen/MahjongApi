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
    public class ChatController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            ChatSingleton chat = ChatSingleton.Instance;
            Console.WriteLine(chat.GetMessages());
            return chat.GetMessages();
        }

        [HttpPost]
        public void Post([FromBody]string m)
        {
            
            ChatSingleton chat = ChatSingleton.Instance;

            chat.AddMessage(m);
        }
    }
}