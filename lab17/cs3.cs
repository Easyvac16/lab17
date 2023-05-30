using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    internal class cs3
    {
        public static void task_3()
        {
            Console.OutputEncoding = Encoding.Unicode;
            int[] array1 = { 1, 2, 4, 5, 5};

            int[] array2 = { 2, 3, 6,5 };

            Console.WriteLine("---------Task 3---------");

            //Виведення масиву 1
            Console.WriteLine("Array 1:" + string.Join(" ", array1));

            //Виведення масиву 2
            Console.WriteLine("Array 2:" + string.Join(" ", array2));

            var difference = array1.Except(array2);
            Console.WriteLine("Різниця масивів:");
            foreach (var numbers in difference)
            {
                Console.WriteLine(numbers);
            }

            Console.WriteLine();

            // Перетин масивів
            var intersection = array1.Intersect(array2);
            Console.WriteLine("Перетин масивів:");
            foreach (var numbers in intersection)
            {
                Console.WriteLine(numbers);
            }

            Console.WriteLine();

            // Об'єднання масивів без дублікатів
            var union = array1.Union(array2);
            Console.WriteLine("Об'єднання масивів без дублікатів:");
            foreach (var numbers in union)
            {
                Console.WriteLine(numbers);
            }

            Console.WriteLine();

            // Вміст першого масиву без повторень
            var distinct = array1.Distinct();
            Console.WriteLine("Вміст першого масиву без повторень:");
            foreach (var numbers in distinct)
            {
                Console.WriteLine(numbers);
            }
            Console.WriteLine();
        }
    }
}
