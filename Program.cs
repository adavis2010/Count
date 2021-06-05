using System;
using System.Collections.Generic;

namespace Count
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] ints = { 8,1,2,5,9,6,1,2,9,8,2,4,7,0,1,3,7,9,4,9,6,8,7,1,9,5,8,4,6,1,8,9,6,6,0,2,7,6,0,6,0,4,7,2,0,1,9,9,1,0,0,8,7,7,4,6,0,1,4,7,5,4,6,8,0,8,6,7,2,0,3,3,8,4,6,2,3,2,8,4,0,4,7,2,0,1,9,9,1,0,0,8,7,7,4,6,0,1,4,7,5,4,6,8,0,8,6,7,2,0,3,3,8,4,6,2,3,2,8,4,6,7,7,4,3,9,4,9,3,0,2,5,3,7,6,2,5,6,2,2,3,4,7,3,6,3,7,0,7,1,7,5,7,3,3,9,0,5,3,8,9,7,7,7,5,5,4,4,7,0,7,1,5,6,5,2,0,8,8,1,7,8,3,3,8,2,0,5,8,2,0,0,0,4,3,8,4,8,7,9,};
            

            var dictionary = new Dictionary<int, int>();
            dictionary.Add(0, 0);
            dictionary.Add(1, 0);
            dictionary.Add(2, 0);
            dictionary.Add(3, 0);
            dictionary.Add(4, 0);
            dictionary.Add(5, 0);
            dictionary.Add(6, 0);
            dictionary.Add(7, 0);
            dictionary.Add(8, 0);
            dictionary.Add(9, 0);

            foreach (var i in ints)
            {
                dictionary[i] = dictionary[i] + 1;
            }
            foreach (var key in dictionary.Keys)
            {
                Console.WriteLine($"The digit {key} occurs {dictionary[key]} times");
            }
        }
    }




















}
    

