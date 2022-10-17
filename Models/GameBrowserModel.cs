using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahjongApi.Models
{
    public class GameBrowserModel
    {
        private List<MahjongEngine> games;
        private int idCounter;

        private static GameBrowserModel? instance;

        public GameBrowserModel()
        {
            idCounter = 0;
            games = new List<MahjongEngine>();
        }

        public static GameBrowserModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameBrowserModel();
                }
                return instance;
            }
        }

        public void NewGame(string name)
        {
            games.Add( new MahjongEngine(idCounter, name) );
            idCounter++;
        }

        public List<string> GetGames()
        {
            var temp = new List<string>();
            foreach (var game in games)
            {
                temp.Add(game.ToString());
            }
            if (temp.Count == 0)
            {
                temp.Add("");
            }
            return temp;
        }

        public void JoinGame(int id, string name)
        {
            foreach (var game in games)
            {
                if (game.gameId == id)
                {
                    game.AddPlayer(name);
                }
            }
        }
    }
}