using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public class Adress
    {
        protected string _country;
        protected string _city;
        protected string _street;
        protected int _house;

        public Adress()
        {
            this._country = "Country";
            this._city = "City";
            this._street = "Street";
            this._house = 0;
        }

        public Adress(string country, string city, string street, int house)
        {
            this._country = country;
            this._city = city;
            this._street = street;
            this._house = house;
        }

        public string toString()
        {
            return (
                "Country: " + this._country +   "\r\n" +
                "City: " + this._city +         "\r\n" +
                "Street: " + this._street +     "\r\n" +
                "House: " + this._house.ToString()
                );
        }
        public Adress inputAdress()
        {
            Console.WriteLine("Country: "); string country = Console.ReadLine();
            Console.WriteLine("City: "); string city = Console.ReadLine();
            Console.WriteLine("Street: "); string street = Console.ReadLine();
            Console.WriteLine("House: "); int house = int.Parse(Console.ReadLine());
            return new Adress(country, city, street, house);
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }

        public int House
        {
            get { return _house; }
            set { _house = value; }
        }
    }
}
