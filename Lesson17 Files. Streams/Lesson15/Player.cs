using System.Collections.Generic;

namespace Drunkard
{
    class Player
    {
        public List<Card> cards;
        public int Number { get; set; }
        public Player(int number)
        {
            Number = number;
            cards = new List<Card>();
        }
        public Player()
        {
            cards = new List<Card>();
        }
        
        
    }
}
