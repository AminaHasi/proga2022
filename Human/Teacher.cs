using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Human
{
    public enum KeyWords { Csharp, Python, Java };
    class Teacher : Human
    {
        private int _salary;
        private string _department;
        private int _numberOfSeats;
        private KeyWords _keywords;
        private List<Student> _list;

        public Teacher() : base()
        {
            _list = new List<Student>();
        }
        
        public Teacher(string name, string surname, int age, double height,
            double weight, bool habits, string email, Nation nation, Address address, int salary, string department, int numberOfSeats, KeyWords keywords) : base(name, surname,
                age, height, weight, habits, email, nation, address)
        {
            _salary = salary;
            _department = department;
            _numberOfSeats = numberOfSeats;
            _keywords = keywords;
            _list = new List<Student>();
        }
        
        public void Add(Student student)
        {
            if (CheckNumberOfSeat(student.Key.ToString()))
            {
                _list.Add(student);
            }
            else
            {
                Console.WriteLine("Мест нет либо интересы не совпадают!");
            }
        }
        
        public void Show()
        {
            foreach (var student in _list)
            {
                student.PrintInfo();
            }
        }
        
        public override void PrintInfo()
        {
            var data =
               ToString() + "\n" +
               "Salary: " + _salary + "\n" +
               "Money: " + _department + "\n" +
                "Number of set: " + _numberOfSeats + "\n" +
                "Key: " + _keywords;
            Console.WriteLine(data);

        }
        
        public void WriteToJson()
        {
            foreach (var student in _list)
            {
                File.AppendAllText("Student.json", JsonConvert.SerializeObject(student,
                    new JsonSerializerSettings {StringEscapeHandling = StringEscapeHandling.EscapeNonAscii}));
            }
        }
        
        public void ReadFromFile()
        {
            _list.Clear();
            using (var reader = new JsonTextReader(new StreamReader("Student.json")))
            {
                reader.SupportMultipleContent = true;
                while (true)
                {
                    if (!reader.Read())
                    {
                        break;
                    }

                    var serializer = new JsonSerializer();
                    var student = serializer.Deserialize<Student>(reader);

                    _list.Add(student);
                }
            }

        }

        public void FindName(string str)
        {
            foreach (var student in _list)
            {
                if (student.Name == str)
                {
                    student.PrintInfo();
                }
                else
                {
                    Console.WriteLine("Объекта с такими инициалами нету в списке!");
                }
            }
        }

        public bool CheckNumberOfSeat(string key) =>
            _list.Count < _numberOfSeats && key == _keywords.ToString();

        public void Remove(string name, string surname)
        {
            for (var n = 0; n < _list.Count; n++)
            {
                if (_list[n].Name == name && _list[n].Surname == surname)
                {
                    _list.RemoveAt(n);
                }
            }
            Console.WriteLine("Удаление прошло успешно!");
        }
        
        public void InputInfo()
        {
            Console.WriteLine("Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Surname: ");
            var surname = Console.ReadLine();
            Console.WriteLine("Age: ");
            int.TryParse(Console.ReadLine(), out var age);
            Console.WriteLine("Height: ");
            double.TryParse(Console.ReadLine(), out var height);
            Console.WriteLine("Weight: ");
            double.TryParse(Console.ReadLine(), out var weight);
            Console.WriteLine("Habbits: ");
            bool.TryParse(Console.ReadLine(), out var habits);
            var email = Console.ReadLine();
            Console.WriteLine("Nation: ");
            var nation = (Nation)Enum.Parse(typeof(Nation), Console.ReadLine(), true);
            Console.WriteLine("Group: ");
            int.TryParse(Console.ReadLine(), out var group);
            Console.WriteLine("Money: ");
            int.TryParse(Console.ReadLine(), out var money);
            var key = (Key)Enum.Parse(typeof(Key), Console.ReadLine(), true);
            var studentOne = new Student(name, surname, age, height, weight, habits, email, nation, Address.InputAddress(), group, money, key);
            Add(studentOne);
        }
        
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        
        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }
        
        public int NumOfSeats
        {
            get { return _numberOfSeats; }
            set { _numberOfSeats = value; }
        }
        
        public KeyWords KeyWords
        {
            get { return _keywords; }
            set { _keywords = value; }
        }
        
        public List<Student> List
        {
            get { return _list; }
            set { _list = value; }
        }
    }
}

