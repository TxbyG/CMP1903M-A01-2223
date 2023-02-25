using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    public class Pack
    {
        private readonly List<Card> pack;

        public Pack()
        {
            pack = new List<Card>();

            //Initialise the card pack here
            foreach (Suit suit in GetValues(typeof(Suit)))
            {
                for (int value = 1; value <= 13; value++)
                {
                    pack.Add(new Card(value, suit));
                }
            }
        }

        private IEnumerable<Suit> GetValues(Type type)
        {
            throw new NotImplementedException();
        }

        public void ShuffleCardPack()
        {
            Random rng = new Random();

            for (int i = pack.Count - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1);
                Card temp = pack[i];
                pack[i] = pack[j];
                pack[j] = temp;
            }
        }
        public Card deal()
        {
            //Deals one card
            if (pack.Count > 0)
            {
                Card card = pack[0];
                pack.RemoveAt(0);
                return card;
            }
            else
            {
                return null;
            }

        }
        public List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            List<Card> cards = new List<Card>();

            for (int i = 0; i < amount; i++)
            {
                Card card = deal();

                if (card == null)
                {
                    break;
                }

                cards.Add(card);
            }

            return cards;
        }
    }
}
