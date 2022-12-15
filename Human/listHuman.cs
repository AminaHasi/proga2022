using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class listHuman
    {
        private List<Human> listHumans;

        public listHuman()
        {
            listHumans = new List<Human>();
        }
        public void addHuman(Human human)
        {
            listHumans.Add(human);
        }
        public List<Human> Humans { get { return listHumans; } }

        public void show()
        {
            for (int i = 0; i < listHumans.Count(); i++)
                listHumans[i].printInfo();
        }
        public string toStr()
        {
            string data = "";
            for (int i = 0; i < listHumans.Count(); i++)
                data += listHumans[i].toStr() +"\r\n" +
                    "+---------------------+" + "\r\n";
            return data;
        }
        public void findCountry_Nation(string country,string nation)
        {
            for (int i = 0; i < listHumans.Count(); i++)
                if (listHumans[i].Adress.Country == country &&
                    listHumans[i].Nation.ToString() == nation)
                    listHumans[i].printInfo();
        }
        public void findName(string name)
        {
            for (int i = 0; i < listHumans.Count(); i++)
            {
                if (listHumans[i].Name == name)
                    listHumans[i].printInfo();
                else
                    Console.WriteLine("Not listed");
            }

        }
        public void findSurname(string surname)
        {
            for (int i = 0; i < listHumans.Count(); i++)
            {
                if (listHumans[i].Surname == surname)
                    listHumans[i].printInfo();
                else
                    Console.WriteLine("Not listed");
            }

        }
        public void find_change_name(string fName, string lName)
        {
            for (int i = 0; i < listHumans.Count(); i++)
            {
                if (listHumans[i].Name == fName)
                {
                    listHumans[i].Name = lName;
                    listHumans[i].printInfo();
                }
            }

        }
        public void find_change_surname(string fSurname, string lSurname)
        {
            for (int i = 0; i < listHumans.Count(); i++)
            {
                if (listHumans[i].Surname == fSurname)
                {
                    listHumans[i].Surname = lSurname;
                    listHumans[i].printInfo();
                }
                else
                    Console.WriteLine("Not listed");
            }
        }
        public void remove(string name, string surname)
        {
            bool check_remove = false;
            for (int i = 0; i < listHumans.Count(); i++)
            {
                if ((listHumans[i].Name == name) && (listHumans[i].Surname == surname))
                {
                    check_remove = true;
                    listHumans.RemoveAt(i);
                }
                
            }
            if (check_remove == true) { Console.WriteLine("removal was successful"); }
            else { Console.WriteLine("ulument missing"); }


        }
        /*public void sort()
        {
        
        }*/
        public void average_age()
        {
            
            if (listHumans.Count() != 0)
            {
                int age = 0;
                for (int i = 0; i < listHumans.Count(); i++)
                    age += listHumans[i].Age;

                float result = age / listHumans.Count();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("List is empty");
            }
        }
        public void show(bool b)
        {
            foreach (Human obj in listHumans)
                obj.printInfo();
        }
        public void sort_surname_by_length()
        {
            Human reserv = new Human();
            for (int j = 1; j < listHumans.Count(); j++)
                for (int i = 0; i < listHumans.Count() - 1; i++)
                    if (((listHumans[i].Surname).ToString()).Length > ((listHumans[i + 1].Surname).ToString()).Length)
                    {
                        reserv = listHumans[i];
                        listHumans[i] = listHumans[i + 1];
                        listHumans[i + 1] = reserv;
                    }
            for (int i = 0; i < listHumans.Count(); i++)
                listHumans[i].printInfo();

            reserv = null;
        }
        public void sort_age()
        {
            Human reserv = new Human();
            for (int j = 1; j < listHumans.Count(); j++)
                for (int i = 0; i < listHumans.Count() - 1; i++)
                    if (listHumans[i].Age > listHumans[i + 1].Age)
                    {
                        reserv = listHumans[i];
                        listHumans[i] = listHumans[i + 1];
                        listHumans[i + 1] = reserv;
                    }
            for (int i = 0; i < listHumans.Count(); i++)
                listHumans[i].printInfo();

            reserv = null;
        }
    }
}
