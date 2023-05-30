using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    internal class cs2
    {
        public static void task_2()
        {
            string[] strings = { "abcd", "xy", "pqrst", "uvc", "ijklmn" };

            Console.WriteLine("---------Task 2---------");

            //Виведення масиву strings
            Console.WriteLine("String Array:" + string.Join(" ", strings));

            // Сортування за зростанням кількості символів
            var sortedAscending = strings.OrderBy(s => s.Length);
            Console.WriteLine("Сортування за зростанням:");
            foreach (var str in sortedAscending)
            {
                Console.WriteLine(str);
            }

            Console.WriteLine();

            // Сортування за спаданням кількості символів
            var sortedDescending = strings.OrderByDescending(s => s.Length);
            Console.WriteLine("Сортування за спаданням:");
            foreach (var str in sortedDescending)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
        }
    }
}
