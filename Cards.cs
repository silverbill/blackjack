using System;
namespace blackjack
{


    public enum Suit
    {
        Hearts,
        Clubs,
        Diamonds,
        Spades
    }

    public enum Rank
    {
        Ace,
        Deuce,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
    public enum Values
    {
        Ace = 11,
        Deuce = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 10,
        Queen = 10,
        King = 10
    }

    public class Card
    {
        public Suit suit;
        public Rank rank;

        public Card(Suit s, Rank r)
        {
            suit = s;
            rank = r;
        }
    }

    public class Deck
    {
        public Card[] cards;
        public Deck()
        {
            cards = new Card[52];
            int i = 0; // 1
            foreach (Rank r in Enum.GetValues(typeof(Rank)))
            {
                int j = 0;
                foreach (Suit s in Enum.GetValues(typeof(Suit)))
                {
                    cards[i * 4 + j] = new Card(s, r);
                    j++;
                }
                i++;
            }
        }
    public Card[] getRandomized()
    {
        return new Card[0];
    }
        //public class Shuffle
        ////would this take deck from above method and shuffles it.
        //{
        //        private static T[] Shuffle<T>(T[] Deck)
        //        {
        //            var matrix = new SortedList();
        //            var r = new Random();

        //            for (var x = 0; x <= Deck.GetUpperBound(0); x++)
        //            {
        //                var i = r.Next();
        //                while (matrix.ContainsKey(i)) { i = r.Next(); }
        //                matrix.Add(i, Deck[x]);
        //            }
        //            var shuffledDeck = new T[Deck.Length];
        //            matrix.Values.CopyTo(shuffledDeck, 0);
        //            return shuffledDeck;

        //        }
        //    }
    }
}