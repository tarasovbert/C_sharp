using System;

namespace Drunkard
{
    class Card
    {
        private Suit suit;
        public Value CardValue { get; }
        

        public Card(Suit suit, Value value)
        {
            this.suit = suit;
            CardValue = value;
        }

        public override string ToString()
        {
            return String.Format("{0} of {1}", CardValue, suit);
        }
    }
}
