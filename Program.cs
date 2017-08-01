using System;
using System.Collections.Generic;
using System.Linq;

namespace puzzles
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            RandomArray();
            TossCoin(rand);
            TossMultipleCoins(11);
            Names();
        }
        static int[] RandomArray()
        {
            int[] randomArray = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; ++i){
                randomArray[i] = rand.Next(5,26);
            }
            int min = randomArray[0];
            int max = randomArray[0];
            int sum = randomArray[0];
            for (int i = 1; i < randomArray.Length; ++i)
            {
                if (min > randomArray[i]){
                    min = randomArray[i];
                }
                if (max < randomArray[i]){
                    max = randomArray[i];
                }
                sum += randomArray[i];
            }
            Console.WriteLine("Minimum: {0}\nMaximum: {1}\nSum: {2}", min, max, sum);
            return randomArray;
        }
        static String TossCoin(Random rand)
        {
            string result = "Heads";
            if (rand.Next(0,2) == 1)
            {
                result = "Tails";
            }
            Console.WriteLine("Result: " + result);
            return result;
        }
        static Double TossMultipleCoins(int num)
        {
            Double headsNum = 0;
            Random rand = new Random();
            for (int i = 0; i < num; ++i){
                if (TossCoin(rand) == "Heads")
                {
                    ++headsNum;
                }
            }
            Console.WriteLine($"Heads Ratio: {headsNum/num}");
            return headsNum/num;
        }
        static string[] Names()
        {
            string[] names = {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            // shuffle
            Random rand = new Random();
            String temp = "";
            for (int i = 0; i < names.Length; ++i)
            {
                int index = rand.Next(i,names.Length);
                temp = names[i];
                names[i] = names[index];
                names[index] = temp;
                Console.WriteLine("Index {0} has {1}", i, names[i]);
            }
            List<string> longNamesList = new List<string>();
            for (int i = 0; i < names.Length; ++i)
            {
                if (names[i].Length > 5){
                    longNamesList.Add(names[i]);
                }
            }
            string[] longNames = longNamesList.ToArray();
            for (int i = 0; i < longNames.Length; ++i)
            {
                Console.WriteLine(longNames[i]);
            }
            return longNames;
        }
    }
}
