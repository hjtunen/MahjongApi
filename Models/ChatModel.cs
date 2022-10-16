using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahjongApi.Models
{
    public class ChatSingleton
    {

        private List<string> chatLog;


        private static ChatSingleton? instance;

        private ChatSingleton() 
        { 
            chatLog = new List<string>();
            chatLog.Add("test1");
            chatLog.Add("test2");
            chatLog.Add("test3");
        }

        public void AddMessage(string message) 
        {
            chatLog.Add(message);
        }

        public List<string> GetMessages()
        {
            return chatLog;
        }

        public static ChatSingleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ChatSingleton();
                }
                return instance;
            }
        }
    }
}