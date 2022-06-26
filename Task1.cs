using System;
using System.Collections.Generic;
using System.Linq;

namespace Laba3
{
    public class Task1
    {
        public static void First()
        {
            int size = 100;
            var nums = new List<int>(size);

            Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
            Console.WriteLine("Начальный список: ");

            var random = new Random();
            for (int i = 0; i < size; i++) nums.Add(random.Next(0, 25));
            TenElemInString(nums);

            Console.WriteLine("\n\nИзменённый список: ");
            ReversedList(nums);
            Console.WriteLine("––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––");
        }

        public static void ReversedList(List<int> list)
        {
            for (int j = 0; j <= list.Count - 10; j += 10)
            {
                if (j % 20 != 0)
                {
                    var result = list.GetRange(j, 10).Reverse<int>();
                    Console.WriteLine(string.Join(" ", result));
                }
                else
                {
                    var result1 = list.GetRange(j, 10);
                    Console.WriteLine(string.Join(" ", result1));
                }
            }
        }

        public static void TenElemInString(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (i % 10 == 0 && i > 0) { Console.WriteLine(); }
                Console.Write(list[i] + " ");
            }
        }
    }
}

