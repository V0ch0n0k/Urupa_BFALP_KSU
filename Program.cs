using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace @class
{
    
  
    class Program
    {   
        static void Main(string[] args)
        {
            
            List<Human> listHuman = new List<Human>();

            
            Human h_1 = new Human();

            Adress adr_h2 = new Adress("French", "French_city", "French_street", 2);
            Human h_2 = new Human("h4_name", "h3", 20, 1.7, 60, true, Nation.Polish, adr_h2);

            Human h_3 = new Human("h3_name", "h2_surname", 30, 1.8, 60, true, Nation.Polish, new Adress("Polish", "Polish_city", "Polish_street", 3));



            h_1.printInfo();
            h_2.printInfo();
            h_3.printInfo();

            listHuman list = new listHuman();
            list.add(h_1);
            list.add(h_2);
            list.add(h_3);
            Console.WriteLine("/////////////////////////////////////////////");

            Console.WriteLine("/////////////////////////////////////////////");
            Student st_1 = new Student(h_1, 231, 2000);
            Student st_2 = new Student("h2_name", "h2_surname", 18, 1.7, 67, true, Nation.Polish, adr_h2, 241, 5000);
            Student st_3 = new Student(h_3, 241, 5000);

            Console.WriteLine("/////////////////////////////////////////////");

            st_1.printInfo();
            st_2.printInfo();
            st_3.printInfo();
            /*Console.WriteLine();
            list.show();
            
            //Human.inputInfo(list);
            Console.WriteLine();

            st_one.printInfo();

            Console.WriteLine();
            list.show();*/
            /*//list.show();
            list.show();
            Console.WriteLine();
            list.sort_age();
            Console.WriteLine();
            list.show();
            Console.WriteLine();
            list.remove("h3_name", "h3_surname");
            Console.WriteLine();
            list.show();


            Console.WriteLine();
            list.remove("h3_name", "h3_surname");
            Console.WriteLine();
            list.show();*/

            
            string check_option = null;
           
            while (check_option != "0")
            {
                Console.WriteLine(
                "Select an action" + "\n" +
                "\n" +
                "1 - print list Human" + "\n" +
                "2 - find Human by attribute" + "\n" +
                "3 - sort Human by last name and display information" + "\n" +
                "4 - sort Human by age and display information" + "\n" +
                "5 - change values of Human fields" + "\n" +
                "6 - create a new Human object and add to the list" + "\n" +
                "7 - remove the Human object." + "\n" +
                "8 - display menu on screen" + "\n" +
                "0 - exit the program.");
                check_option = Console.ReadLine();

                switch (check_option)
                {

                    case "1":
                        list.show();
                        break;
                    case "2":
                        string c = null;
                        while (c != "0")
                        {
                            Console.WriteLine(
                                "Select an action: " + "\n" +
                                 "\n" +
                                 "1 - change name." + "\n" +
                                 "2 - change last name." + "\n" +
                                 "0 - go back.");
                            c = Console.ReadLine();
                            switch (c)
                            {
                                case "0":
                                    break;
                                case "1":
                                    Console.WriteLine("name:  ");
                                    string name = Console.ReadLine();
                                    list.findName(name);
                                    break;
                                case "2":
                                    Console.WriteLine("surname:  ");
                                    string surname = Console.ReadLine();
                                    list.findSurname(surname);
                                    break;
                                case "3":
                                    Console.WriteLine("country:  ");
                                    string country = Console.ReadLine();
                                    Console.WriteLine("nation:  ");
                                    string nation = Console.ReadLine();
                                    list.findCountry_Nation(country, nation);
                                    break;
                                default:
                                    Console.WriteLine("invalid command, try again");
                                    break;
                            }
                        }
                        
                        break;
                    case "3":
                        list.sort_surname_by_length();
                        break;
                    case "4":
                        list.sort_age();
                        break;
                    case "5":
                        c = null;
                        while (c != "0")
                        {
                            Console.WriteLine(
                                "Select an action: " + "\n" +
                                 "\n" +
                                 "1 - change name." + "\n" +
                                 "2 - change last name." + "\n" +
                                 "0 - go back.");
                            c = Console.ReadLine();
                            switch (c)
                            {
                                case "0":
                                    break;
                                case "1":
                                    Console.WriteLine("name change");
                                    Console.WriteLine("change: ");
                                    string firstName = Console.ReadLine();
                                    Console.WriteLine("replace: ");
                                    string secondName = Console.ReadLine();
                                    list.find_change_name(firstName, secondName);
                                    break;
                                case "2":
                                    Console.WriteLine("surname change");
                                    Console.WriteLine("change: ");
                                    string firstSurname = Console.ReadLine();
                                    Console.WriteLine("replace: ");
                                    string secondSurname = Console.ReadLine();
                                    list.find_change_surname(firstSurname, secondSurname);
                                    break;
                                default:
                                    Console.WriteLine("invalid command, try again");
                                    break;
                            }
                        }
                        break;
                    case "6":
                        Human.inputInfo(list);
                        break;
                    case "7":
                        Console.WriteLine("Enter the first and last name of the Person object to delete");
                        Console.WriteLine("name: ");
                        string name_human = Console.ReadLine();
                        Console.WriteLine("surname: ");
                        string surName = Console.ReadLine();
                        list.remove(name_human, surName);
                        break;

                    default:
                        Console.WriteLine("invalid command, try again");
                        break;

                    case "0":
                        Console.WriteLine("exit made");
                        break;

                }

            }

            

            Console.ReadLine(); 
        }
    }
}
