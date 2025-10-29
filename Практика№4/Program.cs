using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;

namespace Практика_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*MonthsWork monthsWork = new MonthsWork();
            monthsWork.WorkWithMonthsArray();*/

            List<Student> studs = new List<Student>();
            studs.Add(new Student("Александр", "Иванов", "Алексеевич", 
                new DateOnly(2002, 8, 14), 2, "AVT-142"));
            studs.Add(new Student("Мария", "Петрова", "Дмитриевна", 
                new DateOnly(2003, 2, 16), 1, "AVT-242"));
            studs.Add(new Student("Дмитрий", "Сидоров", "Владимирович",
                new DateOnly(2002, 5, 9), 2, "AVT-141"));
            studs.Add(new Student("Анна", "Смирнова", "Андреевна", 
                new DateOnly(2006, 6, 11), 3, "AVT-442"));
            studs.Add(new Student("Михаил", "Кузнецов", "Сергеевич",
                new DateOnly(2006, 8, 16), 4, "AVT-142"));
            studs.Add(new Student("Екатерина", "Попова", "Ивановна", 
                new DateOnly(2006, 4, 23), 5, "AVT-142"));
            studs.Add(new Student("Сергей", "Васильев", "Викторович",
                new DateOnly(2006, 8, 14), 6, "AVT-142"));
            studs.Add(new Student("Ольга", "Соколова", "Константиновна", 
                new DateOnly(2006, 4, 20), 1, "AVT-123"));
            studs.Add(new Student("Андрей", "Михайлов", "Александрович", 
                new DateOnly(2006, 2, 24), 2, "AVT-123"));
            studs.Add(new Student("Наталья", "Новикова", "Евгеньевна",
                new DateOnly(2006, 2, 14), 2, "AVT-123"));
            studs.Add(new Student("Алексей", "Фёдоров", "Игоревич",
                new DateOnly(2006, 6, 17), 5, "AVT-122"));
            studs.Add(new Student("Ирина", "Морозова", "Вадимовна", 
                new DateOnly(2006, 5, 4), 3, "AVT-223"));
            studs.Add(new Student("Владимир", "Волков", "Дмитриевич",
                new DateOnly(2006, 1, 5), 4, "AVT-223"));
            studs.Add(new Student("Светлана", "Алексеева", "Валерьевна",
                new DateOnly(2006, 2, 9), 5, "AVT-242"));
            studs.Add(new Student("Иван", "Лебедев", "Артемович",
                new DateOnly(2006, 9, 21), 2, "AVT-342"));
            studs.Add(new Student("Татьяна", "Семёнова", "Викторовна",
                new DateOnly(2006, 10, 23), 3, "AVT-242"));
            studs.Add(new Student("Евгений", "Егоров", "Борисович",
                new DateOnly(2006, 10, 14), 1, "AVT-442"));
            studs.Add(new Student("Юлия", "Павлова", "Андреевна",
                new DateOnly(2006, 12, 12), 1, "AVT-142"));
            studs.Add(new Student("Павел", "Козлов", "Константинович",
                new DateOnly(2006, 12, 15), 1, "AVT-342"));
            studs.Add(new Student("Елена", "Степанова", "Алексеевна",
                new DateOnly(2006, 11, 17), 4, "AVT-112"));

            Console.WriteLine("Существующий список студентов: ");
            foreach (var item in studs) Console.WriteLine(item);
            Console.WriteLine();

            WorkWithLINQ(studs);

            WorkWithExtMethods(studs);
        }

        static private int InputNum()
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out var num) && num > 0)
                    return num;
                Console.WriteLine("Неверный ввод! Повторите: ");
            }
        }

        static private void PrintAll(IEnumerable<Student> someStuds)
        {
            Console.WriteLine("\tИтог:");
            if (someStuds.Count() == 0)
            {
                Console.WriteLine("\t\tНет таких студентов!\n");
                return;
            }
            foreach (var item in someStuds) Console.WriteLine("\t\t" + item);
            Console.WriteLine();
        }

        static private void WorkWithLINQ(List<Student> studs)
        {
            Console.WriteLine("\t\t\tРабота с запросами LINQ\n");

            Console.WriteLine("\tНахождение всех студентов данного курса\n\tВведите номер курса:");
            var n = InputNum();
            var onCourse = from s in studs
                           where s.Course == n
                           select s;
            PrintAll(onCourse);


            Console.WriteLine("\tНахождение самых молодых студентов:");
            var youngestStuds = from s in studs
                                where s.DateOfBirth == (from s2 in studs
                                                        orderby s2.DateOfBirth descending
                                                        select s2).First().DateOfBirth
                                select s;
            PrintAll(youngestStuds);


            Console.WriteLine("\tНахождение студентов заданной группы:\n\tВведите название существующей группы:");
            var grouppa = Console.ReadLine();
            var grouped = from s in studs
                          where s.GroupName == grouppa
                          select s;
            PrintAll(grouped);


            Console.WriteLine("\tУпорядоченный список людей по фамилиям:");
            Console.WriteLine("\tВведите существующую фамилию: ");
            var lastName = Console.ReadLine();
            var allLastNamed = from s in studs
                               where s.LastName == lastName
                               select s;
            PrintAll(allLastNamed);
        }

        static private void WorkWithExtMethods(List<Student> studs)
        {
            Console.WriteLine("\t\t\tРабота с запросами методами расширения\n\n");
            Console.WriteLine("\tНахождение всех студентов данного курса\n\tВведите номер курса:");
            var n = InputNum();
            var allCoarsed = studs.Where(s => s.Course == n);
            PrintAll(allCoarsed);


            Console.WriteLine("\tНахождение самых молодых студентов:");
            var youngestStuds = studs.Where(s => s.DateOfBirth == 
                                        studs.OrderByDescending(s => s.DateOfBirth).First().DateOfBirth);
            PrintAll(youngestStuds);


            Console.WriteLine("\tНахождение студентов заданной группы:\n\tВведите название существующей группы:");
            var grouppa = Console.ReadLine();
            var groupped = studs.Where(s => s.GroupName == grouppa);
            PrintAll(groupped);


            Console.WriteLine("\tУпорядоченный список людей по фамилиям:");
            Console.WriteLine("\tВведите существующую фамилию: ");
            var lastName = Console.ReadLine();
            var allLastNamed = studs.Where(s => s.LastName == lastName);
            PrintAll(allLastNamed);
        }
    }
}
