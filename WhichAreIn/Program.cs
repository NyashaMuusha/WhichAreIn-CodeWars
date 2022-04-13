using System;
using System.Collections.Generic;
using System.Linq;

namespace WhichAreIn
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string[] array1 = { "arp", "live", "strong"};
            string[] array2 = { "lively", "alive", "harp", "sharp", "armstrong"};
            InArray(array1, array2);
        }
        public static string[] InArray(string[] array1, string[] array2)
        {
            List<string> containedWordsList = new List<string>();

            for (int i = 0; i < array1.Length; i++)
            { 
                for (int index = 0; index < array2.Length; index++)
                { 
                    if (array2[index].Contains(array1[i]))
                    {
                        containedWordsList.Add(array1[i]);
                    }
                }
            }
            List<string> listWithoutDuplicates = containedWordsList.Distinct().ToList();

            var listToArray=listWithoutDuplicates.ToArray();
            
            Array.Sort(listToArray);
         
            return listToArray;
        }
        
    }
}