using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public enum KeyWords {csharp, python, java, js}
    public class Teacher : Human
    {
        private int salary;
        private string department;
        private List<Student> list;
        private KeyWords keyWords;
        private int numofseats;

        public Teacher() : base()
        {
            list = new List<Student>();
        }
        public Teacher(string name, string surname, int age, double height,
            double weight, bool habbits, Nation nation, Adress adress, string email, int salary, string department, KeyWords keyWords, int numofseats) : base(name, surname,
                age, height, weight, habbits, nation, adress, email)
        {
            this.salary = salary;
            this.department = department;
            this.list = new List<Student>();
            this.keyWords = keyWords;
            this.numofseats = numofseats;
        }
        public void add(Student human)
        {
            if(check_ofnumset(human.Key.ToString()))
                list.Add(human);
            else
            {
                Console.WriteLine("No seats or wrong key");
            }
        }
        public void show()
        {
            for (int n = 0; n < list.Count(); n++)
                list[n].printInfo();
        }
        public override void printInfo()
        {
            string data =
                base.toStr() + "\n" +
               "Salary: " + this.salary.ToString() + "\n" +
               "Money: " + this.department + "\n" +
               "Number of set: " + this.numofseats + "\n" +
               "Key: " + this.keyWords.ToString();
            Console.WriteLine(data);

        }
        public bool check_ofnumset(string key)
        {
            bool flag = false;
            if ((list.Count < numofseats) && (key == keyWords.ToString()))
                flag = true;
            else
            {
                flag = false;
            }
            return flag;
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }
        public List<Student> List
        {
            get { return list; }
            set { list = value; }
        }
        public int Numofseats
        {
            get { return numofseats; }
            set { numofseats = value; }
        }
        public KeyWords KeyWords
        {
            get { return keyWords; }
            set { keyWords = value; }
        }
    }
    
}
