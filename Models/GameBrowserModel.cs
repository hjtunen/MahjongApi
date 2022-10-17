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

        private static GameModel? instance;

        public GameBrowserModel()
        {
            idCounter = 0;
            games = new List<MahjongEngine>();
        }

        public static GameModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameModel();
                }
                return instance;
            }
        }

        public void NewGame()
        {
            games.Add( new MahjongEngine(idCounter) );
            idCounter++;
        }

        public List<MahjongEngine> GetGames()
        {
            return games;
        }
    }
}