using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            Pack pack = new Pack();
            pack.ShuffleCardPack();

            List<Card> hand = pack.dealCard(5);

            foreach (Card card in hand)
            {
                Console.WriteLine("{0} of {1}", card.Value, card.Suit);
            }

            Console.ReadLine();
        }
    }
}
