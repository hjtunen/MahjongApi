using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MahjongApi.Models
{
    public class MahjongEngine
    {
        private int gameId { get; set; }
        private List<string> players;
        private List<string> tileDeck;
        private List<string> discards;



        public MahjongEngine()
        {
            players = new List<string>();
            tileDeck = new List<string>();
            discards = new List<string>();
            Initialize();
            
            foreach (var item in tileDeck)
            {
                Console.WriteLine(item);
            }

        }

        public void AddPlayer( string name )
        {
            players.Add(name);
        }

        private void Initialize()
        {
            string[] lands = new[] { "s", "p", "m" };

            foreach (string land in lands)
            {
                for (int i = 1; i <= 9; i++)
                {
                    tileDeck.Add( i + land );
                    tileDeck.Add( i + land );
                    tileDeck.Add( i + land );
                    tileDeck.Add( i + land );
                }
            }

            
        }

    }
}