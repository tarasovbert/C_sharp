using System;
using System.Collections.Generic;

namespace Drunkard
{
    public delegate void EventDelegate(string message);   

    public class Game
    {
        public event EventDelegate SomeEvent;
        
        List<Card> deck;
        Array suits;
        Array values;
        int quantityOfCards = 36;
        List<Player> players;

        private void SomethingHappened(string message)
        {
            SomeEvent?.Invoke(message);
        }

        public void Start(int quantityOfPlayers)
        {
            if (quantityOfPlayers < 2 || quantityOfPlayers == 5 || quantityOfPlayers > 6)
                throw new WrongQuantityOfPlayersException("Wrong quantity of players!");
            players = new List<Player>(quantityOfPlayers);
            for (int i = 0; i < quantityOfPlayers; i++)
            {
                players.Add(new Player(i + 1));
            }
            CreateDeck();
            MixDeck();
            BankCards();
            List<Card> table = new List<Card>(players.Count);
            Rounds(players, table);
        }

        private void CreateDeck()
        {
            deck = new List<Card>();
            suits = Enum.GetValues(typeof(Suit));
            values = Enum.GetValues(typeof(Value));
            for (int i = 0; i < suits.Length; i++)
                for (int j = 0; j < values.Length; j++)
                    deck.Add(new Card((Suit)suits.GetValue(i), (Value)values.GetValue(j)));
        }

        private void MixDeck()
        {
            List<Card> mixedDeck = new List<Card>();
            Random random = new Random();
            int index;
            while (mixedDeck.Count < quantityOfCards)
            {
                index = random.Next(deck.Count);
                mixedDeck.Add(deck[index]);
                deck.Remove(deck[index]);
            }
            deck = mixedDeck;
        }

        private void BankCards()
        {
            while (deck.Count > 0)
                for (int i = 0; i < players.Count; i++)
                {
                    players[i].cards.Add(deck[0]);
                    deck.Remove(deck[0]);
                }
        }

        private void Rounds(List<Player> players, List<Card> table)
        {
            int roundNumber = 0;
            int maxValue;
            int[] winnerIndices;
            while (players.Count > 1)
            {
                roundNumber++;
                maxValue = (int)players[0].cards[0].CardValue;
                winnerIndices = new int[1] { 0 };

                for (int i = 0; i < players.Count; i++)
                {
                    table.Add(players[i].cards[0]);
                    if (maxValue < (int)players[i].cards[0].CardValue)
                    {
                        maxValue = (int)players[i].cards[0].CardValue;
                        winnerIndices[0] = i;
                    }
                    players[i].cards.Remove(players[i].cards[0]);
                }

                for (int i = 1; i < players.Count; i++)
                    if (i != winnerIndices[0] && (int)table[i].CardValue == maxValue)
                    {
                        Array.Resize(ref winnerIndices, winnerIndices.Length + 1);
                        winnerIndices[winnerIndices.Length - 1] = i;
                    }

                if (winnerIndices.Length > 1)
                {
                    for (int i = 0; i < winnerIndices.Length; i++)
                    {
                        if (players[winnerIndices[i]].cards.Count == 0)
                            for (int j = i; j < winnerIndices.Length - 1; j++)
                                winnerIndices[i] = winnerIndices[i + 1];
                        Array.Resize(ref winnerIndices, winnerIndices.Length - 1);
                    }
                }
                if (winnerIndices.Length > 1)
                    Contest(players, table, winnerIndices);

                for (int i = table.Count - 1; i >= 0; i--)
                {
                    players[winnerIndices[0]].cards.Add(table[i]);
                    table.Remove(table[i]);
                }                
                SomethingHappened(String.Format("Round {0}. Player #{1} wins and owns {2} cards. ",
                    roundNumber, players[winnerIndices[0]].Number, players[winnerIndices[0]].cards.Count));
                for (int i = 0; i < players.Count; i++)
                    if (players[i].cards.Count == 0)
                    {
                        SomethingHappened(String.Format("Round {0}. Player #{1} lost.", roundNumber, players[i].Number));
                        Console.ReadKey();
                        players.Remove(players[i]);
                    }
            }
            SomethingHappened(String.Format("Player #{0} wins in round #{1}!", players[0].Number, roundNumber));           
        }

        private List<Player> Contest(List<Player> players, List<Card> table, int[] winnerIndices)
        {
            int maxValue = (int)players[winnerIndices[0]].cards[0].CardValue;
            int[] contestWinnerIndices = new int[1] { winnerIndices[0] };
            int j;

            for (int i = 0; i < winnerIndices.Length; i++)
            {
                j = winnerIndices[i];
                table.Add(players[j].cards[0]);
                if (maxValue < (int)players[j].cards[0].CardValue)
                {
                    maxValue = (int)players[j].cards[0].CardValue;
                    contestWinnerIndices[0] = j;
                }
                players[j].cards.Remove(players[j].cards[0]);
            }

            for (int i = 0; i < winnerIndices.Length; i++)
                if (i != contestWinnerIndices[0] && (int)table[i].CardValue == maxValue)
                {
                    Array.Resize(ref contestWinnerIndices, contestWinnerIndices.Length + 1);
                    contestWinnerIndices[contestWinnerIndices.Length - 1] = winnerIndices[i];
                }

            if (contestWinnerIndices.Length > 1)
                Contest(players, table, contestWinnerIndices);

            for (int i = table.Count - 1; i >= 0; i--)
            {
                players[contestWinnerIndices[0]].cards.Add(table[i]);
                table.Remove(table[i]);
            }
            return players;
        }
    }
}
