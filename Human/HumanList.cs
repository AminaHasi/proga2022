using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Human
{
    class HumanList
    {
        private List<Human> _humansList;

        public HumanList()
        {
            _humansList = new List<Human>();
        }
        
        public void Add(Human human)
        {
            _humansList.Add(human);
        }

        public void Show()
        {
            foreach (var human in _humansList)
            {
                human.PrintInfo();
            }
        }

        public override string ToString()
        {
            var data = String.Empty;
            foreach (var t in _humansList)
            {
                data += t.ToString();
            }
            return data;
        }
        
        public void FindByCountryAndNation(string country, string nation)
        {
            foreach (var human in _humansList)
            {
                if (human.Address.Country == country 
                    && human.Nation.ToString() == nation)
                {
                    human.PrintInfo();
                }
            }
        }
        
        public void FindName(string name)
        {
            foreach (var t in _humansList)
            {
                if (t.Name == name)
                {
                    t.PrintInfo();
                }
                else
                {
                    Console.WriteLine("Объекта с такими инициалами нет в списке!");
                }
            }
        }
        
        public void Remove(string name, string surname)
        {
            for (var n = 0; n < _humansList.Count; n++)
            {
                if (_humansList[n].Name == name && _humansList[n].Surname == surname)
                {
                    _humansList.RemoveAt(n);
                }
            }
            Console.WriteLine("Удаление прошло успешно!");
        }
        
        public void AverageAge()
        {
            var age = _humansList.Sum(t => t.Age);
            if (_humansList.Any())
            {
                var result = age / (float)_humansList.Count;
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Список пустой");
            }

        }
        
        public void SortBySurname()
        {
            for (var j = 1; j < _humansList.Count; j++)
            {
                for (var i = 0; i < _humansList.Count - 1; i++)
                {
                    if (_humansList[i].Surname[0] > _humansList[i + 1].Surname[0])
                    {
                        (_humansList[i], _humansList[i + 1]) = (_humansList[i + 1], _humansList[i]);
                    }
                }
            }

            foreach (var human in _humansList)
            {
                human.PrintInfo();
            }
        }
       
    }
}
