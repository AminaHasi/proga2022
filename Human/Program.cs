using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;



namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            var listHuman = new List<Human>();
            var address1 = new Address("Ukraine", "Poltava", "Vilove", 10);
            var list = new HumanList();

            var listTeacher = new TeacherList();
            var student1 = new Student("Jane", "Ternova", 20, 1.78, 65, false, "la@gmail.com", Nation.Ukrainian, new Address("Ukraine", "Poltava", "Hover", 20), 241, 3000, Key.Csharp);
            var teacher1 = new Teacher("Viktoria", "Lavrova", 30, 1.83, 65, false, "j@gmail.com", Nation.French, new Address("France", "Paris", "Agrev", 54), 20000, "FKNFM", 2, KeyWords.Csharp);
            teacher1.Add(student1);
            var choice = String.Empty;
            while (choice != "0")
            {
                Console.WriteLine("Выберите действие ");
                Console.WriteLine("0 - выйти с программы.");
                Console.WriteLine("1 - распечатать все объекты");            
                Console.WriteLine("2 - записать список студентов в файл");
                Console.WriteLine("3 - прочитать файл со списом студентов");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "0":
                        Console.WriteLine("До свидания!");
                        break;
                    case "1":
                        teacher1.Show();
                        break;
                    case "2":
                        teacher1.WriteToJson();
                        break;
                    case "3":
                        teacher1.ReadFromFile();
                        teacher1.Show();
                        break;

                    default:
                        Console.WriteLine("Вы ввели неверный номер!");
                        break;

                }
            }
            Console.WriteLine("Hi");
            Thread.Sleep(5000000);
            
         

        }

    }

}
