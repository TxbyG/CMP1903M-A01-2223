using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        private int value;
        //Suit: numbers 1 - 4
        private int suit;
        //The 'set' methods for these properties could have some validation

        public int Value
        {
            get { return value; }
            set { Value = value; }
        }

        public int Suit
        {
            get { return suit; }
            set { Suit = suit; }
        }

        public Card(int value, int suit)
        {
            if (value <= 1 || value >= 13 && suit <= 1 || suit >= 4)
            {
                throw new ArgumentException("Invalid card value.");
            }

            this.value = value;
            this.suit = suit;
        }
    }
}
