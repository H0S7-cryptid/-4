using System.Linq;
using System.Security.Cryptography;

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

            Console.WriteLine("\tНахождение всех студентов данного курса\n\tВведите номер курса:");
            var n = InputNum();
            var onCourse = from s in studs
                           where s.Course == n
                           select s;
            Console.WriteLine("\tИтог:");
            foreach(var item in onCourse) Console.WriteLine(item);

            Console.WriteLine("\tНахождение самых молодых студентов:");
            var youngest = (from s in studs
                           orderby s.DateOfBirth descending
                           select s).First().DateOfBirth;
            var youngestStuds = from s in studs
                       where s.DateOfBirth == youngest
                       select s;
            Console.WriteLine("\tИтог");
            foreach (var item in youngestStuds) Console.WriteLine(item);

            Console.WriteLine("\tНахождение студентов заданной группы:\n\tВведите название существующей группы:");
            var grouppa = Console.ReadLine();
            var grouped = from s in studs
                          where s.GroupName == grouppa
                          select s;
            Console.WriteLine("\tИтог");
            foreach(var item in grouped) Console.WriteLine(item);

            Console.WriteLine("\tУпорядоченный список людей по фамилиям:");
            Console.WriteLine("\tВведите существующую фамилию: ");
            var lastName = Console.ReadLine();
            var allLastNamed = from s in studs
                               where s.LastName == lastName
                               select s;
            Console.WriteLine("\tИтог");
            foreach (var item in allLastNamed) Console.WriteLine(item);
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
    }
}
