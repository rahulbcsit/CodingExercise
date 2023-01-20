using System;
using System.Linq;
using System.Collections.Generic;

namespace Proximo
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new List<string>() { "zopp","aab", "aabc", "rshaym", "sss" , "ss"};
            var result = SortList.CustomSort(input);
           // result.ForEach(x => Console.WriteLine(x));
            
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
}



