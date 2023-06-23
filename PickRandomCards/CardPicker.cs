﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PickRandomCards
{
    internal class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            int value = random.Next(1, 5);

            switch (value)
            {
                case 1:
                    return "Spades";
                case 2:
                    return "Heart";
                case 3:
                    return "Clubs";
                default:
                    return "Diamonds";
            }
        }

        private static string RandomValue()
        {
            throw new NotImplementedException();
        }
    }
}
