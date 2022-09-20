using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    public enum Key { Csharp, Python, Java }
    class Student : Human
    {
        private int _group;
        private int _money;
        private Key _key;

        public Student() : base()
        {
        }
        
        public Student(string name, string surname, int age, double height,
            double weight, bool habits, string email, Nation nation, Address address, int group, int money, Key key) : base(name, surname,
                age, height, weight, habits, email, nation, address)
        {
            _group = group;
            _money = money;
            _key = key;
        }
        
        public override void PrintInfo()
        {
            var data =
               ToString() + "\n" +
               "Group: " + _group + "\n" +
               "Money: " + _money + "\n" +
                "Key: " + _key;
            Console.WriteLine(data);

        }
        
        public int Group
        {
            get { return _group; }
            set { _group = value; }
        }
        
        public int Money
        {
            get { return _money; }
            set { _money = value; }
        }
        
        public Key Key
        {
            get { return _key; }
            set { _key = value; }
        }
    }
}
