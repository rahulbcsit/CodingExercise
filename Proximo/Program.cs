using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace Proximo
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<string>() { "zopp","aab", "aabc", "rshaym", "sss" , "ss"};
            var result = SortList.CustomSort(input);
            // result.ForEach(x => Console.WriteLine(x));


            BobRental bob = new BobRental();
            var res = bob.TotalPrice("2023/01/1", 5);
            Console.WriteLine(res);
            Console.ReadKey();

        }
    }

    public static class SortList
    {
        public static List<string> CustomSort(List<string> input)
        {
            if (input == null)
            {
                return input;
            }

            var sortedList = new List<string>();

            foreach (var word in input)
            {
                var current = word.ToCharArray();
                Array.Sort(current);
                sortedList.Add(word);

            } 
            return  sortedList.OrderBy(x => x).ToList();

        }
    }

    public class BobRental
    {

        private readonly Dictionary<int, int[]> dict = new Dictionary<int, int[]>();
        
        public BobRental()
        {
            dict.Add(1, new int[] { 50, 49, 48, 45 });

            dict.Add(2, new int[] { 50, 49, 48, 45 });

            dict.Add(3, new int[] { 50, 49, 48, 45 });

            dict.Add(4, new int[] { 51, 50, 49, 48 }); 

            dict.Add(5, new int[] { 54, 54, 54, 54 }); 
        }

        public string TotalPrice(string date, int days)
        {
            DateTimeOffset parsedDate;
            if (!DateTimeOffset.TryParse(date, out parsedDate))
            {
                throw new ArgumentOutOfRangeException(nameof(date), "Invalid DateOffset");
            }

            var currentMonth = parsedDate.Month;
            var currentDay = parsedDate.Day + days;

            if (dict.ContainsKey(currentMonth))
            {
                var index = 0;

                if (currentDay <= 3)
                {
                    index = 0;
                }
                else if (currentDay <= 8)
                {
                    index = 1;
                }
                else if (currentDay <= 15)
                {
                    index = 2;
                }
                else
                {
                    index = 3;
                }
                var result = dict[currentMonth][index] * days;
                return result.ToString("C0");
            }
            else
            {
                throw new ArgumentException(nameof(currentMonth), "month not implemented");
            }

        }
    }
}



