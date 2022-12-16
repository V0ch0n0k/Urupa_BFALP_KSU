using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppUrupaBohdan
{
    public class Student : Human
    {
        private int _group;
        private int _scholarship;
        private List<TermPaper_Class> _listTermPaper;

        public Student() : base()
        {
            this._group = 231;
            this._scholarship = 2000;
            this._listTermPaper = new List<TermPaper_Class>();
        }
        public Student(
            string name, string surname, int age, Nation nation, Adress_Class adress,
            int group, int scholarship)
            : base(name, surname, age, nation, adress)
        {
            this._group = group;
            this._scholarship = scholarship;
            this._listTermPaper = new List<TermPaper_Class>();
        }
        public Student(
            Human h,
            int group, int scholarship)
            : base(h)
        {
            this._group = group;
            this._scholarship = scholarship;
            this._listTermPaper = new List<TermPaper_Class>();
        }
        public Student(Student S) : base(S.Name, S.Surname, S.Age,  S.Nation, S.Adress)
        {
            this._group = S.Group;
            this._scholarship = S.Scholarship;
        }

        //  +-------function-------+
        public void addTermPaper(TermPaper_Class coursework)
        {
            _listTermPaper.Add(coursework);
        }
        public void clearTermPaper()
        {
            _listTermPaper.Clear();
        }
        public void RemoveTermPaper(TermPaper_Class tp)
        {
            if (_listTermPaper.Contains(tp))
            {
                _listTermPaper.Remove(tp);
            }
        }


        public override void inputData()
        {
            base.inputData();

            Console.WriteLine("Group: "); this.Group = int.Parse(Console.ReadLine());
            Console.WriteLine("Scholarship: "); this.Scholarship = int.Parse(Console.ReadLine());
            //this.TermPaper = (new TermPaper_Class()).inputTermPaper();
        }
        public override string toStr()
        {
            return
                (base.toStr() + "\n" +
                "Group: " + this.Group.ToString() + "\n" +
                "Scholarship: " + this.Scholarship.ToString() + "\n" /*+
                this.TermPaper.toStr()*/
                );
        }
        public override void printInfo() => this.toStr();

        //  +-------get/set-------
        public int Group
        {
            get { return _group; }
            set { _group = value; }
        }
        public int Scholarship
        {
            get { return _scholarship; }
            set { _scholarship = value; }
        }
        public List<TermPaper_Class> LTermPaper
        {
            get { return _listTermPaper; }
            set { _listTermPaper = value; }
        }
    }
}
