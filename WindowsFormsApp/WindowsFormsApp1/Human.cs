using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppUrupaBohdan
{
    public enum Nation { Ukranian, French, Polish, American, British };
    public class Human
    {
        private string __name;
        private string __surname;
        private string __photo;
        private int __age;
        private Nation __nation;
        private Adress_Class __adress;


        public Human()
        {
            this.__name = "My_name";
            this.__surname = "My_surname";
            //this.__photo = ".."
            this.__age = 18;
            this.__nation = Nation.Ukranian;
            this.__adress = new Adress_Class();
        }
        public Human(string name, string surname, int age, Nation nation, Adress_Class adress)
        {
            this.__name = name;
            this.__surname = surname;
            this.__age = age;
            this.__nation = nation;
            this.__adress = adress;
        }
        public Human(Human H)
        {
            this.__name = H.__name;
            this.__surname = H.__surname;
            this.__age = H.__age;
            this.__nation = H.__nation;
            this.__adress = H.__adress;
        }

        //  +-------function-------+
        public virtual void inputData()
        {
            Console.WriteLine("Name: "); this.Name = Console.ReadLine();
            Console.WriteLine("Surname: "); this.Surname = Console.ReadLine();
            Console.WriteLine("Age: "); this.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Nation: "); this.Nation = (Nation)Enum.Parse(typeof(Nation), Console.ReadLine(), true);
            this.Adress = (new Adress_Class()).inputAdress();
        }
        public virtual string toStr()
        {
            return
                ("Name: " + this.Name + "\n" +
                "Surname: " + this.Surname + "\n" +
                "Age: " + this.Age.ToString() + "\n" +
                "Nation: " + this.Nation.ToString() + "\n" +
                this.Adress.toStr());
        }
        public virtual void printInfo() => this.toStr();

        //  +-------get/set-------+
        public string Name
        {
            get { return __name; }
            set { __name = value; }
        }
        public string Surname
        {
            get { return __surname; }
            set { __surname = value; }
        }
        public int Age
        {
            get { return __age; }
            set { __age = value; }
        }
        public Nation Nation
        {
            get { return __nation; }
            set { __nation = value; }
        }
        public Adress_Class Adress
        {
            get { return __adress; }
            set { __adress = value; }
        }
    }
}
