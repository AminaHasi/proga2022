using System;

namespace Human
{
    class Address
    {
        private string _country;
        private string _city;
        private string _street;
        private int _house;

        public Address()
        {
            _country = "Ukraine";
            _city = "Poltava";
            _street = "Ternova";
            _house = 6;
        }

        public Address(string country, string city, string street, int house)
        {
            _country = country;
            _city = city;
            _street = street;
            _house = house;
        }

        public override string ToString()
        {
            return
                "Country: " + _country + "\n" +
                "City: " + _city + "\n" +
                "Street: " + _street + "\n" +
                "House: " + _house;
        }
        
        public static Address InputAddress()
        {
            Console.WriteLine("Country ");
            var country = Console.ReadLine();
            Console.WriteLine("City: ");
            var city = Console.ReadLine();
            Console.WriteLine("Street: ");
            var street = Console.ReadLine();
            Console.WriteLine("House: ");
            int.TryParse(Console.ReadLine(), out var house);
            return new Address(country, city, street, house);
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
