using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практика_4
{
    public class MonthsWork
    {
        public void WorkWithMonthsArray()
        {
            // Первая часть работы
            Console.WriteLine("Изначальный массив с данными: ");
            var months = new string[] { "January", "February", "March", "April",
                "May", "June", "July", "August", "September", "November", "December" };
            foreach (var item in months) Console.Write(item + " ");
            Console.WriteLine();

            FindLength(months);

            Console.WriteLine("\tВыбор летних и зимних месяцев в массиве: ");
            Console.WriteLine("\tLINQ - Запросы");
            var summerAndWinter1 = from m in months
                                   where m == "June" || m == "July" || m == "August"
                                   || m == "December" || m == "January" || m == "February"
                                   select m;
            foreach (var item in summerAndWinter1) Console.Write(item + " ");
            Console.WriteLine();

            Console.WriteLine("\tLINQ - Методы расширения");
            var summerAndWinter2 = months.Where(m => m == "June" || m == "July" || m == "August"
                                    || m == "December" || m == "January" || m == "February");
            foreach (var item in summerAndWinter1) Console.Write(item + " ");
            Console.WriteLine("\n");

            Console.WriteLine("\tВывод данных по алфавиту: ");
            Console.WriteLine("\tLINQ - Запросы");
            var orderedMonths1 = from m in months
                                 orderby m
                                 select m;
            foreach (var item in orderedMonths1) Console.Write(item + " ");
            Console.WriteLine();

            Console.WriteLine("\tLINQ - Методы расширения");
            var orderedMonths2 = months.OrderBy(m => m);
            foreach (var item in orderedMonths2) Console.Write(item + " ");
            Console.WriteLine("\n");

            Console.WriteLine("\tНахождение строк, содержащих \"u\" и длиной не менее 4 символов: ");
            Console.WriteLine("\tLINQ - Запросы");
            var selectedUnderCondition1 = from m in months
                                          where m.Contains("u") && m.Length >= 4
                                          select m;
            foreach (var item in selectedUnderCondition1) Console.Write(item + " ");
            Console.WriteLine();

            Console.WriteLine("\tLINQ - методы расширения");
            var selectedUnderCondition2 = months.Where(m => m.Length >= 4 && m.Contains("u"));
            foreach (var item in selectedUnderCondition2) Console.Write(item + " ");
            Console.WriteLine();
        }

        private void FindLength(string[] months)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out var len) &&
                    len <= months.MaxBy(m => m.Length).Length && len > 0)
                {
                    Console.WriteLine("\tВывод данных по заданной длине строки");
                    Console.WriteLine("\tLINQ - Запросы");
                    var sertainLenStr = from m in months 
                                        where m.Length == len 
                                        select m;
                    foreach (var item in sertainLenStr) Console.WriteLine(item);

                    Console.WriteLine("\tLINQ - Методы расширения");
                    sertainLenStr = months.Where(m => m.Length == len);
                    foreach (var item in sertainLenStr) Console.WriteLine(item);

                    break;
                }
                else Console.WriteLine("Wrong length! Try again");
            }

        }
    }
}
