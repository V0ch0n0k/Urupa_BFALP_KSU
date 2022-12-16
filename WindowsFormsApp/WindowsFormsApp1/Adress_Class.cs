using FakeItEasy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppUrupaBohdan
{
    public class Adress_Class
    {
        private string _country;
        private string _city;
        private string _street;
        private int _house;

        public Adress_Class()
        {
            this._country = "Ukraine";
            this._city = "Kherson";
            this._street = "My_street";
            this._house = 1;
        }
        public Adress_Class(string country, string city, string street, int house)
        {
            this._country = country;
            this._city = city;
            this._street = street;
            this._house = house;
        }
        public Adress_Class(Adress_Class AC)
        {
            this._country = AC._country;
            this._city = AC._city;
            this._street = AC._street;
            this._house = AC._house;
        }

        //  +-------function-------+
        public Adress_Class inputAdress()
        {
            Console.WriteLine("Country: "); string country = Console.ReadLine();
            Console.WriteLine("City: ");    string city = Console.ReadLine();
            Console.WriteLine("Street: ");  string street = Console.ReadLine();
            Console.WriteLine("House: ");   int house = int.Parse(Console.ReadLine());

            Adress_Class adress = new Adress_Class(country, city, street, house);
            return adress;
        }
        public void set_Adress(string country, string city, string street, int house)
        {
            this.Country = country;
            this.City = city;            
            this.Street = street;
            this.House = house;
        }
        public string toStr()
        {
            return
                ("Country: " + this._country + "\n" +
                 "City: " +    this._city +    "\n" +
                 "Street: " +  this._street +  "\n" +
                 "House: " +   this._house.ToString());
        }
        public void printInfo() => this.toStr();


        //  +-------get/set-------+
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
