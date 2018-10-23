using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Dealer
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }


        public void Deal(List<Card> Hand)//This method deals the cards it takes in a list of cards and adds in a card
        {
            Hand.Add(Deck.Cards.First());            //Hand is a list with the built in method add First is a method that takes the first thing
            Console.WriteLine(Deck.Cards.First().ToString() + "\n");//prints the card that was dealt
            Deck.Cards.RemoveAt(0); //this removes the first item from the deck 
        }
    }
}
