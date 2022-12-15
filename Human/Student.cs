using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public enum Key {csharp, python, java, js}
    public class Student : Human
    {
        private int group;
        private int money;
        private Key key;

        public Student() : base()
        {

        }
        public Student(string name, string surname, int age, double height,
            double weight, bool habbits, Nation nation, Adress adress, string email, int group, int money, Key key) : base(name, surname,
                age, height, weight, habbits, nation, adress, email)
        {
            this.group = group;
            this.money = money;
            this.key = key;
        }
        public void printInfo()
        {
            string data =
               "Group: " + this.group.ToString() + "\n" +
               "Money: " + this.money.ToString() + "\n" +
               "Key: " + this.key.ToString();
            Console.WriteLine(data);

        }
        public int Group
        {
            get { return group; }
            set { group = value; }
        }
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
        public Key Key
        {
            get { return key; }
            set { key = value; }
        }
    }
}
