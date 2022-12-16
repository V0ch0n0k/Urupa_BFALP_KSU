using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppUrupaBohdan
{
    public class TermPaper_Class
    {
        private string _title;
        private string _description;
        private DateTime _deadline;

        public TermPaper_Class()
        {
            _title = "title of my work";
            _description = "description of my work";
            _deadline = new DateTime(2022, 12, 12);
        }
        public TermPaper_Class(string title, string description, DateTime deadline)
        {
            this._title = title;
            this._description = description;
            this._deadline = deadline;
        }
        public TermPaper_Class(TermPaper_Class TP)
        {
            this._title = TP.Title;
            this._description = TP.Description;
            this._deadline = TP.Deadline;
        }
        //  +-------function-------+
        public TermPaper_Class inputTermPaper()
        {
            Console.WriteLine("Title: "); string title = Console.ReadLine();
            Console.WriteLine("Description: "); string description = Console.ReadLine();
            Console.WriteLine("Deadline: "); DateTime deadline = DateTime.Parse(Console.ReadLine());

            TermPaper_Class tP = new TermPaper_Class(title, description, deadline);
            return tP;
        }
        public string toStr()
        {
            return
                ("Title: " + this.Title + "\n" +
                 "Description: " + this.Description + "\n" +
                 "Deadline: " + this.Deadline.ToString());
        }
        public void printInfo() => this.toStr();

        //  +-------get/set-------+
        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        public DateTime Deadline
        {
            get { return _deadline; }
            set { _deadline = value; }
        }
    }
}
