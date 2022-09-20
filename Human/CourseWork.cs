using System;

namespace Human
{
    struct UDC
    {
        private int _id;
        private string _udc;
        
        public UDC(int id, string udc)
        {
            _id = id;
            _udc = udc;
        }
        
        public override string ToString()
        {
            return "Id: " + _id + "\n" + "Name: " + _udc;
        }
        
        public int Id
        {
            get => _id;
            set => _id = value;
        }
        
        public string Udc
        {
            get => _udc;
            set => _udc = value;
        }
    }
    
    class CourseWork
    {
        private string _description;
        private string _name;
        private DateTime _date;
        private UDC _udc;
        public CourseWork(string description, string name, DateTime date, UDC udc)
        {
            _description = description;
            _name = name;
            _date = date;
            _udc = udc;
        }

        public void PrintInfo()
        {
            var text = "Description: " + _description + "\n" +
                       "Name: " + _name + "\n" +
                       "Date: " + _date + "\n" +
                       "UDC: " + _udc;

            Console.WriteLine(text);
        }
        
        public override string ToString()
        {
            return "Description: " + _description + "\n" +
                 "Name: " + _name + "\n" +
                 "Date: " + _date + "\n" +
                 "UDC: " + _udc;
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        
        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }
        
        public UDC Udc
        {
            get { return _udc; }
            set { _udc = value; }
        }

    }
}
