using System;

namespace Puzzles
{
    class Program
    {
        static int[] RandomArray()
        {
            int[] newarr = new int[10];
            Random rand = new Random();
            int min = 26;
            int max = newarr[0];
            int sum = 0;
            for(var i = 0; i<newarr.Length; i++)
            {
                newarr[i] = rand.Next(5,26);
                sum+=newarr[i];
                if (newarr[i] > max)
                {
                    max = newarr[i];
                }
                if (newarr[i] < min)
                {
                    min = newarr[i];
                }
            }
            return newarr;
        }
        static string CoinFlip()
        {
            string coin = "Deciding";
            int result = 0;
            Console.WriteLine("Tossing a Coin!");
            Random rand = new Random();
                result = rand.Next(1,3);
                if (result == 1)
                {
                    coin = "Heads";
                    Console.WriteLine(coin);
                }
                else if (result == 2)
                {
                    coin = "Tails";
                    Console.WriteLine(coin);
                }
            return coin;
        }
        static double TossMultipleCoins(int num)
        {
            double heads = 0;
            double tails = 0;
            for(int i = 0; i<num;i++)
            {
                string result = CoinFlip();
                if (result =="Heads")
                {
                    heads+=1;
                }
                if (result =="Tails")
                {
                    tails+=1;
                }
            }
            double HeadsToTails = heads/tails;
            return HeadsToTails;
        }
        static string[] Names()
        {
            string[] NamesInOrder = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            string[] RandomNames = new string[5];
            int check = 0;
            Random rand = new Random();
            for(int i = 0; i < NamesInOrder.Length; i++)
            {
                int j = rand.Next(0,NamesInOrder.Length);
                RandomNames[i] = NamesInOrder[j];
                Console.WriteLine(RandomNames[i]);
                if(RandomNames[i].Length > 5)
                {
                    check+=1;
                }
            }
            string[] LongNames = new string[check];
            int index = -1;
            for(int j = 0; j < RandomNames.Length; j++)
            {
                if(RandomNames[j].Length > 5)
                {
                    index+=1;
                    LongNames[index] = RandomNames[j];
                }
            }
            return LongNames;
        }
        static void Main(string[] args)
        {
            int[] intarr = RandomArray();
            string coin = CoinFlip();
            double coins = TossMultipleCoins(5);
            Console.WriteLine("Heads to tails ratio: " + coins);
            string[] names = Names();
        }
    }
}
