using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq_3
{
    internal class Task2
    {
        public static void task2()
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 4, 5, 6, 7, 8 };

            // Різниця між двома масивами
            var difference = array1.Except(array2);
            Console.WriteLine("Різниця між масивами:");
            foreach (var num in difference)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            // Перетин двох масивів
            var intersection = array1.Intersect(array2);
            Console.WriteLine("Перетин масивів:");
            foreach (var num in intersection)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            // Об'єднання двох масивів
            var union = array1.Union(array2);
            Console.WriteLine("Об'єднання масивів:");
            foreach (var num in union)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            // Вміст першого масиву без повторень
            var distinct = array1.Distinct();
            Console.WriteLine("Вміст першого масиву без повторень:");
            foreach (var num in distinct)
            {
                Console.WriteLine(num);
            }
        }
    }
}
