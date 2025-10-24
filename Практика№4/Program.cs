using System.Linq;

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
                new DateOnly(2006, 4, 20), 1, "AVT-142"));
            studs.Add(new Student("Андрей", "Михайлов", "Александрович", 
                new DateOnly(2006, 2, 24), 2, "AVT-142"));
            studs.Add(new Student("Наталья", "Новикова", "Евгеньевна",
                new DateOnly(2006, 2, 14), 2, "AVT-142"));
            studs.Add(new Student("Алексей", "Фёдоров", "Игоревич",
                new DateOnly(2006, 6, 17), 5, "AVT-142"));
            studs.Add(new Student("Ирина", "Морозова", "Вадимовна", 
                new DateOnly(2006, 5, 4), 3, "AVT-142"));
            studs.Add(new Student("Владимир", "Волков", "Дмитриевич",
                new DateOnly(2006, 1, 5), 4, "AVT-142"));
            studs.Add(new Student("Светлана", "Алексеева", "Валерьевна",
                new DateOnly(2006, 2, 9), 5, "AVT-142"));
            studs.Add(new Student("Иван", "Лебедев", "Артемович",
                new DateOnly(2006, 9, 21), 2, "AVT-142"));
            studs.Add(new Student("Татьяна", "Семёнова", "Викторовна",
                new DateOnly(2006, 10, 23), 3, "AVT-142"));
            studs.Add(new Student("Евгений", "Егоров", "Борисович",
                new DateOnly(2006, 10, 14), 1, "AVT-142"));
            studs.Add(new Student("Юлия", "Павлова", "Андреевна",
                new DateOnly(2006, 12, 12), 1, "AVT-142"));
            studs.Add(new Student("Павел", "Козлов", "Константинович",
                new DateOnly(2006, 12, 15), 1, "AVT-142"));
            studs.Add(new Student("Елена", "Степанова", "Алексеевна",
                new DateOnly(2006, 11, 17), 4, "AVT-142"));

            Console.WriteLine("Нахождение всех студентов данного курса");

            Console.WriteLine("Нахождение самых молодых студентов:");
            var youngest = (from s in studs
                           orderby s.DateOfBirth descending
                           select s).First().DateOfBirth;
            var youngestStuds = from s in studs
                       where s.DateOfBirth == youngest
                       select s;
            foreach (var item in youngestStuds) Console.WriteLine(item);

            Console.WriteLine("Нахождение студентов заданной группы:");

            Console.WriteLine("Упорядоченный список людей по фамилиям:");

        }
    }
}
