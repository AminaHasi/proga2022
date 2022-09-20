using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Human
{
    class TeacherList
    {
        private List<Teacher> _list;
        public TeacherList()
        {
            _list = new List<Teacher>();
        }

        public void Add(Teacher teacher)
        {
            _list.Add(teacher);
        }
        
        public void Show()
        {
            foreach (var teacher in _list)
            {
                teacher.PrintInfo();
            }
        }
        
        public List<Teacher> List
        {
            get { return _list; }
            set { _list = value; }
        }
    }
}
