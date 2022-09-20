using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public enum Nation { Ukrainian, French, Polish };
    class Human
    {
        protected string _name;
        protected string _surname;
        protected int _age;
        protected double _height;
        protected double _weight;
        protected bool Habits;
        protected string _email;
        protected Nation _nation;
        protected Address _address;

        public Human()
        {
            _name = "Jane";
            _surname = "Ford";
            _age = 18;
            _height = 1.78;
            _weight = 56;
            Habits = false;
            _email = "janeford@gmail.com";
            _nation = Nation.French;
            _address = new Address();
        }
        
        public Human(string name, string surname, int age, double height, double weight, bool habits, string email, Nation nation, Address address)
        {
            _name = name;
            _surname = surname;
            _age = age;
            _height = height;
            _weight = weight;
            Habits = habits;
            _email = email;
            _nation = nation;
            _address = address;
        }
        
        public static Human operator +(Human one, Human two) => new Human
        {
            _age = one._age + two._age,
            Habits = one.Habits && two.Habits
        };
        
        public static bool operator >(Human one, Human two) => one._age > two._age;
        
        public static bool operator <(Human one, Human two) => one._age < two._age;
        
        public virtual void PrintInfo()
        {
            var data =
                "Name: " + _name + "\n" +
                "Surname: " + _surname + "\n" +
                "Age: " + _age + "\n" +
                "Height: " + _height + "\n" +
                "Weight: " + _weight + "\n" +
                "Is Habbits: " + Habits + "\n" +
                "Email: " + _email + "\n" +
                "Nation: " + _nation + "\n" +
                "Adress: " + _address;
            Console.WriteLine(data);
        }
        
        public override string ToString() => 
             "Name: " + _name + "\n" +
             "Surname: " + _surname + "\n" +
             "Age: " + _age + "\n" +
             "Height: " + _height + "\n" +
             "Weight: " + _weight + "\n" +
             "Is Habbits: " + Habits + "\n" +
             "Email: " + _email + "\n" +
             "Nation: " + _nation + "\n" +
             "Address: " + _address;
        
        public void InputInfo(HumanList humanList)
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
            Console.WriteLine("Email: ");
            var email = Console.ReadLine();
            Console.WriteLine("Nation: ");
            var nation = (Nation)Enum.Parse(typeof(Nation), Console.ReadLine(), true);
            var address = new Address();
            var human = new Human(name, surname, age, height, weight, habits, email, nation, Address.InputAddress());
            humanList.Add(human);
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        public bool Habbits
        {
            get { return Habbits; }
            set { Habbits = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public Nation Nation
        {
            get { return _nation; }
            set { _nation = value; }
        }

        public Address Address
        {
            get { return _address; }
            set { _address = value; }
        }

    }
}
