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
        private List<List<string>> hands;


        public MahjongEngine()
        {
            players = new List<string>();
            tileDeck = new List<string>();
            discards = new List<string>();
            hands = new List<List<string>>();
            Initialize();
            
            foreach (var item in tileDeck)
            {
                Console.WriteLine(item);
            }

            foreach (var hand in hands)
            {
                Console.WriteLine( hand.Aggregate((tiles, tile) => tiles + " " + tile) );
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

            hands.Add(new List<string>());
            hands.Add(new List<string>());
            hands.Add(new List<string>());
            hands.Add(new List<string>());

            for (int i = 0; i < 13; i++)
            {
                hands[0].Add(tileDeck[0]);
                tileDeck.RemoveAt(0);
                hands[1].Add(tileDeck[0]);
                tileDeck.RemoveAt(0);
                hands[2].Add(tileDeck[0]);
                tileDeck.RemoveAt(0);
                hands[3].Add(tileDeck[0]);
                tileDeck.RemoveAt(0);
            }


            
        }

    }
}