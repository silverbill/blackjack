using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace blackjack
{
    class Program
    {
    static void Main(string[] args)
    {
        Deck dealerDeck = new Deck();
        // dealerDeck.cards; // [Card...]
        dealerDeck.cards.ToList().ForEach(Console.WriteLine); //prints blackjack.Cards to console about 30 times

            Enum.GetValues(typeof(Card));
            for (int i = 1; i < 51; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write(" ");
                }
              
                else
                {
                    Console.Write(i + " ");
                }
            }
                // 1. Print out two cards for the user, and one dealer card
                var myCards = new Card[2];
        //var dealerCards = new Card[2];
        // 2. Hit me?
        // if Console.ReadLine() == "Y" -> 
        // myCards = new Card[3]...
        // 3. Hit me?
        // 4. Someone wins, or draw.

        
    }




    //public static void Run()
    //{
    //    Debug.Assert(Deck == 52);
    //    Debug.Assert(shuffledDeck != Deck);
    //    Debug.Assert(vectorLength(new float[2, 2] { { 0, 1 }, { 0, 0 } }) == 1);

    }



}   

