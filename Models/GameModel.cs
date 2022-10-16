using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahjongApi.Models
{
    public class GameModel
    {
        private List<MahjongEngine> games;

        private static GameModel? instance;

        public GameModel()
        {
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
            games.Add( new MahjongEngine() );
        }
    }
}