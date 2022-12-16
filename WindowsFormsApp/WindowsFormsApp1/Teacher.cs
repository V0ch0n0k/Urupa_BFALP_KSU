using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppUrupaBohdan
{
    public class Teacher : Human
    {

        private string _discipline;
        private int _salary;
        private List<Student> _lStudents = new List<Student>();

        public Teacher() : base()
        {
            this._discipline = "My_discipline";
            this._salary = 0;

            _lStudents = new List<Student>(10);
        }

        public Teacher(
            string name, string surname, int age,
            Nation nation, Adress_Class adress, string discipline, int salary)
            : base(name, surname, age, nation, adress)
        {
            this._discipline = discipline;
            this._salary = salary;

            _lStudents = new List<Student>(10);
        }
        public Teacher(
            Human h,
            string discipline, int salary)
            : base(h)
        {
            this._discipline = discipline;
            this._salary = salary;

            _lStudents = new List<Student>(10);
        }
        public Teacher(Teacher Tr) : base(Tr.Name, Tr.Surname, Tr.Age, Tr.Nation, Tr.Adress)
        {
            this._discipline = Tr.Discipline;
            this._salary = Tr.Salary;

            this._lStudents = Tr.LStudents;
        }

        //  +-------function-------+
        public void add(Student student)
        {
            _lStudents.Add(student);
        }
        public void clear()
        {
            _lStudents.Clear();
        }
        public void RemoveStudent(Student st)
        {
            if (_lStudents.Contains(st))
            {
                _lStudents.Remove(st);
            }
        }

        public override void inputData()
        {
            base.inputData();

            Console.WriteLine("Discipline: "); this.Discipline = Console.ReadLine();
            Console.WriteLine("Salary: "); this.Salary = int.Parse(Console.ReadLine());
        }
        public override string toStr()
        {
            return
                (base.toStr() + "\n" +
                "Salary: " + this.Salary);
        }

        public override void printInfo() => this.toStr();

        //  +-------get/set-------
        public string Discipline
        {
            get { return _discipline; }
            set { _discipline = value; }
        }
        public int Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
        public List<Student> LStudents
        {
            get { return _lStudents; }
            set { _lStudents = value; }
        }
    }
}
