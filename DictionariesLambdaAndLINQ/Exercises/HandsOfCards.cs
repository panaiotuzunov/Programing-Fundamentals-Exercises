using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HandsOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> playersCards = new Dictionary<string, List<string>>();

            while (!input.Equals("JOKER"))
            {
                string[] inputArgs = input.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string player = inputArgs[0];

                List<string> cards = inputArgs[1].Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(card => card.Trim()).ToList();

                if (!playersCards.ContainsKey(player))
                {
                    playersCards[player] = new List<string>();
                }

                playersCards[player].AddRange(cards);

                input = Console.ReadLine();
            }

            PrintAllPlayersScore(playersCards);
        }

        private static void PrintAllPlayersScore(Dictionary<string, List<string>> playersCards)
        {
            foreach (var player in playersCards.Keys)
            {
                List<string> curentPlayerCards = playersCards[player].Distinct().ToList();
                int score = 0;

                for (int i = 0; i < curentPlayerCards.Count; i++)
                {
                    string card = curentPlayerCards[i];

                    int power = GetCardPower(card);
                    int type = GetCardType(card);
                    score += power * type;
                }

                Console.WriteLine("{0}: {1}", player, score);
            }
        }

        private static int GetCardType(string card)
        {
            Dictionary<string, int> types = new Dictionary<string, int>();
            types["S"] = 4;
            types["H"] = 3;
            types["D"] = 2;
            types["C"] = 1;

            string type = card.Substring(card.Length - 1);
            return types[type];
        }

        private static int GetCardPower(string card)
        {
            Dictionary<string, int> powers = new Dictionary<string, int>();
            powers["2"] = 2;
            powers["3"] = 3;
            powers["4"] = 4;
            powers["5"] = 5;
            powers["6"] = 6;
            powers["7"] = 7;
            powers["8"] = 8;
            powers["9"] = 9;
            powers["10"] = 10;
            powers["J"] = 11;
            powers["Q"] = 12;
            powers["K"] = 13;
            powers["A"] = 14;

            string power = card.Substring(0, card.Length - 1);
            return powers[power];
        }
    }
}
