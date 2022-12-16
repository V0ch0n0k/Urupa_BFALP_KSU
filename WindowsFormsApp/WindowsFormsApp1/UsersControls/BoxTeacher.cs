using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppUrupaBohdan.UsersControls
{
    public partial class BoxTeacher : UserControl
    {
        private Form1 _form1;
        private Teacher _teacher;
        public Teacher Teacher
        {
            get { return _teacher; }
            set { this._teacher = value; }
        }
        public BoxTeacher(Form1 _form1)
        {
            this._form1 = _form1;
            this._teacher = new Teacher();
            InitializeComponent();
        }
        public BoxTeacher(Teacher teacher, Form1 _form1)
        {
            this._form1 = _form1;
            this._teacher = teacher;
            
            InitializeComponent();
            this.labelSurnameTeach.Text = _teacher.Surname;
            this.labelNameTeach.Text = _teacher.Name;
            this.labelDiscipline.Text = _teacher.Discipline;
            this.labelAmountStudents.Text = "Студентів: " + _teacher.LStudents.Count.ToString();
        }


        private void buttonDeleteTeacher_Click(object sender, EventArgs e)
        {
            _form1._teacherList.RemoveTeacher(_teacher);
            _form1.showTeachers();
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            _form1.openNewMenu(new FormAddStudent(_form1, this));
            _form1.showStudents(_teacher);
        }

        private void buttonShowMyStudents_Click(object sender, EventArgs e)
        {
            _form1.showStudents(_teacher);
        }


    }
}
