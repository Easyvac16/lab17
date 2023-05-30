using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab17
{
    internal class cs1
    {
        public static void task_1()
        {
            Console.OutputEncoding = Encoding.Unicode;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 9, 2, 9, 10,945,946,947,948,949,950,952 };

            Console.WriteLine("---------Task 1---------");

            //Виведення масиву
            Console.WriteLine("Array:" + string.Join(" ", array));

            // Розрахунок добутку елементів масиву
            int product = array.Aggregate((x, y) => x * y);
            Console.WriteLine("Добуток: " + product);

            // Розрахунок кількості елементів масиву
            int count = array.Count();
            Console.WriteLine("Кількість елементів: " + count);

            // Розрахунок кількості елементів масиву, кратних 9
            int NumberMultiple9 = array.Count(x => x % 9 == 0);
            Console.WriteLine("Кількість елементів, кратних 9: " + NumberMultiple9);

            // Розрахунок кількості елементів масиву, кратних 7 і більших, ніж 945
            int MultipleNumbers7Greater945 = array.Count(x => x % 7 == 0 && x > 945);
            Console.WriteLine("Кількість елементів, кратних 7 і більших, ніж 945: " + MultipleNumbers7Greater945);

            // Розрахунок суми елементів масиву
            int sum = array.Sum();
            Console.WriteLine("Сума: " + sum);

            // Розрахунок суми парних елементів масиву
            int sumEvenNumbers = array.Where(x => x % 2 == 0).Sum();
            Console.WriteLine("Сума парних елементів: " + sumEvenNumbers);

            // Знаходження мінімуму в масиві
            int min = array.Min();
            Console.WriteLine("Мінімум: " + min);

            // Знаходження максимуму в масиві
            int max = array.Max();
            Console.WriteLine("Максимум: " + max);

            // Знаходження трьох перших максимальних чисел
            var topThreeGrades = array.OrderByDescending(grade => grade).Take(3);
            Console.WriteLine("Три перші максимальні елементи:");
            Console.WriteLine(string.Join(" ", topThreeGrades));

            // Знаходження трьох перших мінімальних чисел
            var lowerThreeGrades = array.OrderBy(grade => grade).Take(3);
            Console.WriteLine("Три перші мінімальні елементи:");
            Console.WriteLine(string.Join(" ", lowerThreeGrades));

            // Знаходження середнього значення в масиві
            double average = array.Average();
            Console.WriteLine("Середнє значення: " + average);

            // Статистика входження кожного числа до масиву
            var numberOccurrences = array.ToLookup(x => x);
            Console.WriteLine("Статистика входження кожного числа:");
            foreach (var occurrence in numberOccurrences)
            {
                Console.WriteLine(occurrence.Key + " - " + occurrence.Count() + " раз(и)");
            }

            // Статистика входження парних чисел у масив
            var evenNumberOccurrences = array.Where(x => x % 2 == 0).ToLookup(x => x);
            Console.WriteLine("Статистика входження парних чисел:");
            foreach (var occurrence in evenNumberOccurrences)
            {
                Console.WriteLine(occurrence.Key + " - " + occurrence.Count() + " раз(и)");
            }

            // Статистика входження парних і непарних чисел до масиву
            var oddEvenNumberOccurrences = array.ToLookup(x => x % 2 == 0 ? "Парні" : "Непарні");
            Console.WriteLine("Статистика входження парних і непарних чисел:");
            foreach (var occurrence in oddEvenNumberOccurrences)
            {
                Console.WriteLine(occurrence.Key + " - " + occurrence.Count() + " раз(и)");
            }
            Console.WriteLine();
        }
    }
}
