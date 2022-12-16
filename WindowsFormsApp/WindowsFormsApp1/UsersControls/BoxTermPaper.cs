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
    public partial class BoxTermPaper : UserControl
    {
        private Form1 _form1;
        private Teacher _teacher;
        private Student _student;
        private TermPaper_Class _termPaper;

        public TermPaper_Class TermPaper
        {
            get { return _termPaper; }
            set { this._termPaper = value; }
        }
        public BoxTermPaper(Teacher teacher,Student student, TermPaper_Class termPaper, Form1 _form1)
        {
            this._form1 = _form1;
            this._teacher = teacher;
            this._student = student;
            this._termPaper = termPaper;
            InitializeComponent();

            richTextBox_title.Text = "Назва: " + termPaper.Title;
            richTextBox_description.Text = "Опис: " + termPaper.Description;

            label_deadline.Text = "Дедлайн: " + termPaper.Deadline.ToShortDateString();
            if (termPaper.Deadline.Date < DateTime.Today)
            { label_deadline.ForeColor = Color.Red; }
            else { label_deadline.ForeColor = Color.Black; }
        }
 
        private void buttonDeleteTermPaper_Click(object sender, EventArgs e)
        {
            _student.RemoveTermPaper(_termPaper);
            _form1.showTermPaper(_teacher, _student);
            
        }
    }
}
