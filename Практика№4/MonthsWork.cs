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
            Console.WriteLine("Изначальный массив с данными: ");
            var months = new string[] { "January", "February", "March", "April",
                "May", "June", "July", "August", "September", "November", "December" };
            foreach (var item in months) Console.Write(item + " ");
            Console.WriteLine();

            FindLength(months);

            Console.WriteLine("Выбор летних и зимних месяцев в массиве:\n");
            Console.WriteLine("\tLINQ - Запросы\n");
            var summerAndWinter1 = from m in months
                                   where m == "June" || m == "July" || m == "August"
                                   || m == "December" || m == "January" || m == "February"
                                   select m;
            PrintAll(summerAndWinter1);
            Console.WriteLine("\tLINQ - Методы расширения\n");
            var summerAndWinter2 = months.Where(m => m == "June" || m == "July" || m == "August"
                                    || m == "December" || m == "January" || m == "February");
            PrintAll(summerAndWinter2);


            Console.WriteLine("Вывод данных по алфавиту:\n");
            Console.WriteLine("\tLINQ - Запросы\n");
            var orderedMonths1 = from m in months
                                 orderby m
                                 select m;
            PrintAll(orderedMonths1);
            Console.WriteLine("\tLINQ - Методы расширения\n");
            var orderedMonths2 = months.OrderBy(m => m);
            PrintAll(orderedMonths2);


            Console.WriteLine("Нахождение строк, содержащих \"u\" и длиной не менее 4 символов:\n");
            Console.WriteLine("\tLINQ - Запросы\n");
            var selectedUnderCondition1 = from m in months
                                          where m.Contains("u") && m.Length >= 4
                                          select m;
            PrintAll(selectedUnderCondition1);
            Console.WriteLine("\tLINQ - методы расширения\n");
            var selectedUnderCondition2 = months.Where(m => m.Length >= 4 && m.Contains("u"));
            PrintAll(selectedUnderCondition2);
        }

        private void FindLength(string[] months)
        {
            Console.WriteLine("Введите длину названия месяца: ");
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

                    break; // Выход из цикла после печати нужных данных
                }
                else Console.WriteLine("Неверно введена длина! Повторите ввод:");
            }

        }

        private void PrintAll(IEnumerable<string>? someMonths)
        {
            Console.WriteLine("\tИтог");
            if (someMonths.Count() == 0)
            {
                Console.WriteLine("Нет таких месяцев!");
                return;
            }
            foreach (var item in someMonths) Console.WriteLine(item + " ");
            Console.WriteLine();
        }
    }
}
