using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        int[] valueNumbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

        //Suit: numbers 1 - 4
        int[] suitNumbers = new int[] { 1, 2, 3, 4 };
        //The 'set' methods for these properties could have some validation

        public int Value 
        { 
            get { return Value; }
            set { Value = (int)valueNumbers.GetValue(1, 4);  }
        }

        public int Suit {
            get { return Suit; }
            set { Suit = (int)suitNumbers.GetValue(1, 4); } 
        }
    }
}
