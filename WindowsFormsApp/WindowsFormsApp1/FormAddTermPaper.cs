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
    public partial class FormAddTermPaper : Form
    {
        private Form1 _form1;
        private Teacher _teacher;
        private UsersControls.BoxStudent _boxStudent;
        
        public FormAddTermPaper(Form1 _form1, Teacher teacher, UsersControls.BoxStudent boxStudent)
        {
            this._form1 = _form1;
            this._teacher = teacher;
            this._boxStudent = boxStudent;
            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string title = textBox_title.Text;
            string description = textBox_description.Text;
            DateTime deadline;  DateTime.TryParse(dateTimePicker_deadline.Text, out deadline);

            if (
                string.IsNullOrWhiteSpace(title))
            { labelMessage.Text = "Не коректні данні"; return; }

            _boxStudent.Student.addTermPaper(new TermPaper_Class(title, description, deadline));
            
            _form1.showTermPaper(_teacher, _boxStudent.Student);
            labelMessage.Text = "";
        }
    }
}
