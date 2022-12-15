using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    class CourseWork
    {
        private string description;
        private string name;
        private DateTime date;
        public CourseWork(string description, string name, DateTime date)
        {
            this.description = description;
            this.name = name;
            this.date = date;
        }
        public void printInfo()
        {
            string text = "Description: " + this.description + "\n" +
                "Name: " + this.name + "\n" + "Date: " + this.date;
            Console.WriteLine(text);
        }
        public string strinfo()
        {
            return "Description: " + this.description +
                "Name: " + this.name + "Date: " + this.date;
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }
}
