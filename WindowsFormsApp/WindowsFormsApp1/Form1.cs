using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppUrupaBohdan
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private Form _activeForm;
        private Form2 _form2;
        public TeacherList _teacherList = new TeacherList();
        static Random r = new Random();
        public void UpdateContent()
        {
            showTeachers();
        }
        
        private static double GetPseudoDoubleWithinRange(double lowerBound, double upperBound)
        {
            var rDouble = r.NextDouble();
            var rRangeDouble = rDouble * (upperBound - lowerBound) + lowerBound;
            return rRangeDouble;
        }
        private DateTime RandomDateTime()
        {
            DateTime lowerBound = new DateTime(2022, 1, 1);
            DateTime upperBound = (new DateTime(2024, 1, 1));
            int range = (upperBound - lowerBound).Days;
            
            return lowerBound.AddDays(r.Next(range));
        }
        private Human GenerationRandomHuman()
        {
            string[] arr_name = { "Богдан", "Ігор", "Артем", "Михайло", "Дар'я", "Анна", "Марія", "Олександра", "Лелуш" };
            string[] arr_surname = { "Урупа", "Шевчук", "Коваль", "Шевченко", "Мельник", "Ткаченко", "Козак", "Кравченко", "Дирко", "Іващук", "Ламперуж " };
            string[] arr_street = { "Ушакова", "Суворова", "Університетська", "Чорноморська", "Перекопська", "Тракторана", "Молодіжна", "Острывська" };

            string name = arr_name[r.Next(0,8)];
            string surname = arr_surname[r.Next(0,10)];
            int age = r.Next(20, 40);
            Nation nation = (Nation)r.Next(4);
            Adress_Class adress = new Adress_Class("Україна", "Херсон", arr_street[r.Next(0,8)], r.Next(1, 90));

            return (new Human(name, surname, age, nation, adress));
        }
        private Teacher GenerationRandomTeacher()
        {
            string[] arr_discipline = { "Програмування", "Фізика", "Математика", "Українська мова", "Англійська мова", "Загальна методика","Мат. аналіз" };


            string discipline = arr_discipline[r.Next(0,7)];
            int salary = r.Next(1500, 3500);

            return (new Teacher(GenerationRandomHuman(), discipline, salary));
        }
        private Student GenerationRandomStudent()
        {
            int group = r.Next(1,5);
            int scholarship = r.Next(1500, 3500);
            return (new Student(GenerationRandomHuman(), group, scholarship));
        }
        private TermPaper_Class GenerationRandomTermPaper()
        {
            int num_TermPaper = r.Next(100);
            string title = "Курсова№" + num_TermPaper.ToString();
            string description = "Опис№" + num_TermPaper.ToString();
            DateTime deadline = RandomDateTime();
            
            return (new TermPaper_Class(title, description, deadline));
        }

        

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            openNewMenu(new FormAddTeacher(this));
        }

        public void showTeachers()
        {
            flowLayoutPanelPeople.Controls.Clear();
            for (int i = 0; i < _teacherList.TList.Count; i++)
            {
                flowLayoutPanelPeople.Controls.Add(new UsersControls.BoxTeacher(_teacherList.TList[i], this));
            }
        }
        public void showStudents(Teacher teacher)
        {
            flowLayoutPanelPeople.Controls.Clear();
            flowLayoutPanelPeople.Controls.Add(new UsersControls.BoxTeacher(teacher, this));
            for (int i = 0; i < teacher.LStudents.Count; i++)
            {
                flowLayoutPanelPeople.Controls.Add(new UsersControls.BoxStudent(teacher, teacher.LStudents[i], this));
            }
        }
        public void showTermPaper(Teacher teacher, Student student)
        {
            flowLayoutPanelPeople.Controls.Clear();
            flowLayoutPanelPeople.Controls.Add(new UsersControls.BoxTeacher(teacher, this));
            flowLayoutPanelPeople.Controls.Add(new UsersControls.BoxStudent(teacher, student, this));
            for (int i = 0; i < student.LTermPaper.Count; i++)
            {
                flowLayoutPanelPeople.Controls.Add(new UsersControls.BoxTermPaper(teacher, student, student.LTermPaper[i], this));
            }
        }

        public void openNewMenu(Form newMenu)
        {
            if (_activeForm != null)
            { _activeForm.Close(); }

            _activeForm = newMenu;
            newMenu.TopLevel = false;
            newMenu.FormBorderStyle = FormBorderStyle.None;
            
            this.panelAddPeople.Controls.Add(newMenu);
            newMenu.BringToFront();
            newMenu.Show();
        }

        private void buttonTeachers_Click(object sender, EventArgs e)
        {
            showTeachers();
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            int i=0,
                j=0;
            for (int a = r.Next(1, 4); a > 0; a--)
            {
                _teacherList.add(GenerationRandomTeacher());
                i = _teacherList.TList.Count-1;
                for (int b = r.Next(1, 4); b > 0; b--)
                {
                    _teacherList.TList[i].add(GenerationRandomStudent());
                    j = _teacherList.TList[i].LStudents.Count-1;

                    for (int c = r.Next(1, 4); c > 0; c--)
                    { _teacherList.TList[i].LStudents[j].addTermPaper(GenerationRandomTermPaper()); }
                }
            }
            showTeachers();
        }
        private void buttonTabularData_Click(object sender, EventArgs e)
        {
            if (_form2 != null)
            { _form2.UpdateContentForm2(); }
            else
            {
                _form2 = new Form2(_teacherList, this);
                _form2.Show();
            }
        }

        private void flowLayoutPanelPeople_Paint(object sender, PaintEventArgs e)
        {
            if (_form2 != null)
            { _form2.UpdateContentForm2(); }
        }
    }
}
