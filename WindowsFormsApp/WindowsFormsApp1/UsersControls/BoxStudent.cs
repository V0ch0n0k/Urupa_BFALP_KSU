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
    public partial class BoxStudent : UserControl
    {

        private Form1 _form1;
        private Teacher _teacher;
        private Student _student;
        public Student Student
        {
            get { return _student; }
            set { this._student = value; }
        }

        public BoxStudent(Teacher teacher, Form1 _form1)
        {
            this._form1 = _form1;
            this._teacher = teacher;
            this._student = new Student();
            InitializeComponent();
        }
        public BoxStudent(Teacher teacher, Student student, Form1 _form1)
        {
            this._form1 = _form1;
            this._teacher = teacher;
            this._student = student;
            InitializeComponent();
            this.labelSurnameStudent.Text = _student.Surname;
            this.labelNameStudent.Text = _student.Name;
            this.labelAmountTermPaper.Text = "Кільк. курсових: " + _student.LTermPaper.Count.ToString();
        }
        
        private void buttonDeleteStudent_Click(object sender, EventArgs e)
        {
            
            this._teacher.RemoveStudent(_student);
            _form1.showStudents(_teacher);
        }

        private void buttonAddTermPaper_Click(object sender, EventArgs e)
        {
            _form1.openNewMenu(new FormAddTermPaper(_form1, _teacher, this));
            _form1.showTermPaper(_teacher, _student);
        }

        private void buttonTermPaper_Click(object sender, EventArgs e)
        {
            _form1.showTermPaper(_teacher, _student);
        }
    }
}
