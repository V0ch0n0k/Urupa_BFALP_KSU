using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @class
{
    class Student : Human
    {
        private int group;
        private int money;

        public Student() : base() {}
        public Student(Human hum, int group, int money) 
            : base(hum.Name, hum.Surname, hum.Age, hum.Height, hum.Weight, hum.Habbits, hum.Nation, hum.Adress)
        {
            this.group = group;
            this.money = money;
        }
        public Student(string name, string surname, int age, double height, double weight, bool habbits,
            Nation nation, Adress adress, int group, int money)
            : base (name, surname, age, height, weight, habbits, nation, adress)
        {
            this.group = group;
            this.money = money;
        }
        public override  void printInfo()
        {
            string data =
                base.toStr() + "\n" +
                "Group: " + this.group.ToString() + "\n" +
                "Money: " + this.money.ToString();

            Console.WriteLine(data);
        }
        public int Group
        {
            get { return group; }
            set { group = value; }
        }
        public int Money
        {
            get { return money; }
            set { money = value; }
        }
    }
}
