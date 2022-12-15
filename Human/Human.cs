using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public enum Nation { Ukranian, French, Polish };
    public class Human
    {
        protected string __name;
        protected string __surname;
        protected int __age;
        protected double __height;
        protected double __weight;
        protected bool __habbits;
        protected Nation __nation;
        protected Adress __adress;
        private string __email;


        public Human()
        {
            Console.WriteLine("creature Person");
            this.__name = "Name";
            this.__surname = "Surname";
            this.__age = 0;
            this.__height = 0;
            this.__weight = 0;
            this.__habbits = false;
            this.__nation = Nation.Ukranian;
            this.__adress = new Adress();
            this.__email = "gogogo@gmail.com";
            Console.WriteLine("Creation completed Person");
        }
        public Human(string name, string surname, int age, double height, double weight, bool habbits, Nation nation, Adress adress, string email)
        {
            this.__name = name;
            this.__surname = surname;
            this.__age = age;
            this.__height = height;
            this.__weight = weight;
            this.__habbits = habbits;
            this.__nation = nation;
            this.__adress = adress;
            this.__email = email;
        }
        public string toStr()
        {
            string str =
                "Name: " + this.__name +                     "\r\n" +
                "Surname: " + this.__surname +               "\r\n" +
                "Age: " + this.__age.ToString() +            "\r\n" +
                "Height: " + this.__height.ToString() +      "\r\n" +
                "Weight: " + this.__weight.ToString() +      "\r\n" +
                "Is Habbits: " + this.__habbits.ToString() + "\r\n" +
                "Nation: " + this.__nation.ToString() +      "\r\n" +
                "Adress: " + this.__adress.toString();
            return str;
        }
        public virtual void printInfo()
            { Console.WriteLine(this.toStr()); }

        public static void inputInfo(listHuman list)
        {
            Console.WriteLine("Name: "); string name = Console.ReadLine();
            Console.WriteLine("Surname: "); string surname = Console.ReadLine();
            Console.WriteLine("Age: "); int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Height: "); double height = double.Parse(Console.ReadLine());
            Console.WriteLine("Weight: "); double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Habbits: "); bool habbits = bool.Parse(Console.ReadLine());
            Console.WriteLine("Nation: "); Nation nation = (Nation)Enum.Parse(typeof(Nation), Console.ReadLine(), true);
            Adress adr = new Adress();
            Console.WriteLine("Email: "); string email = Console.ReadLine();
            Human n = new Human(name, surname, age, height, weight, habbits, nation, adr.inputAdress(), email);
            list.addHuman(n);
        }

        public string Name
        {
            get { return __name; }
            set { __name = value; }
        }

        public string Surname
        {
            get { return __surname; }
            set { __surname = value; }
        }

        public int Age
        {
            get { return __age; }
            set { __age = value; }
        }

        public double Height
        {
            get { return __height; }
            set { __height = value; }
        }
        public double Weight
        {
            get { return __weight; }
            set { __weight = value; }
        }

        public bool Habbits
        {
            get { return __habbits; }
            set { __habbits = value; }
        }

        public Nation Nation
        {
            get { return __nation; }
            set { __nation = value; }
        }

        public Adress Adress
        {
            get { return __adress; }
            set { __adress = value; }
        }
        
    }
}