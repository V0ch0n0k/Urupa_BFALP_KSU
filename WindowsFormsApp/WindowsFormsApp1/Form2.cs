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
    public partial class Form2 : Form
    {
        private Form1 _form1;
        TeacherList _teacherList;
        public Form2(TeacherList teacherList,Form1 form1)
        {
            this._form1 = form1;
            InitializeComponent();
            UpdateContentForm2();
        }
        public void UpdateContentForm2()
        {
            showTreeView_tree();
            showDataGridViewTeacher();
            showDataGridViewStudent();
            showchartTeacher();
            showchartStudent();
        }
        private void showTreeView_tree()
        {
            DateTime dl;
            Color col = Color.Black;
            treeView_tree.Nodes.Clear();
            for (int a = 0; a < _form1._teacherList.TList.Count(); a++)
            {
                treeView_tree.Nodes.Add(_form1._teacherList.TList[a].Name + _form1._teacherList.TList[a].Surname);
                for (int b = 0; b < _form1._teacherList.TList[a].LStudents.Count(); b++)
                {
                    treeView_tree.Nodes[a].Nodes.Add(_form1._teacherList.TList[a].LStudents[b].Name + _form1._teacherList.TList[a].LStudents[b].Surname);
                    for (int c = 0; c < _form1._teacherList.TList[a].LStudents[b].LTermPaper.Count(); c++)
                    {
                        treeView_tree.Nodes[a].Nodes[b].Nodes.Add(_form1._teacherList.TList[a].LStudents[b].LTermPaper[c].Title);
                        dl = _form1._teacherList.TList[a].LStudents[b].LTermPaper[c].Deadline;
                        if (dl< DateTime.Today) { col = Color.Red; }
                        else { col = Color.Black; }
                        treeView_tree.Nodes[a].Nodes[b].Nodes[c].Nodes.Add((_form1._teacherList.TList[a].LStudents[b].LTermPaper[c].Deadline).ToShortDateString()).ForeColor = col;
                    }
                }
            }
        }
        
        private void showDataGridViewTeacher()
        {
            string[] strColumnsTeacher = { "Ім'я", "Прізвище", "Дисципліна", "Зарплата", "Вік", "Національність", "Адреса" };
            _teacherList = _form1._teacherList;
            DataTable table = new DataTable();

            for (int i = 0; i < strColumnsTeacher.Length; i++)
            {
                table.Columns.Add(strColumnsTeacher[i]);
            }
            for (int i = 0; i < _teacherList.TList.Count; i++)
            {
                Teacher t = _teacherList.TList[i];
                table.Rows.Add(t.Name,t.Surname, t.Discipline, t.Salary, t.Age, t.Nation, t.Adress.toStr());
            }

            this.dataGridViewTeacher.DataSource = table;
        }
        private void showDataGridViewStudent()
        {
            string[] strColumnsStudent = { "Ім'я", "Прізвище", "Група", "Стипендія", "Вік", "Національність", "Адреса" };
            _teacherList = _form1._teacherList;
            DataTable table = new DataTable();

            for (int i = 0; i < strColumnsStudent.Length; i++)
            {
                table.Columns.Add(strColumnsStudent[i]);
            }
            for (int i = 0; i < _teacherList.TList.Count; i++)
            {
                Teacher t = _teacherList.TList[i];
                for (int j = 0; j < _teacherList.TList[i].LStudents.Count; j++)
                {
                    Student s = _teacherList.TList[i].LStudents[j];
                    table.Rows.Add(s.Name, s.Surname, s.Group, s.Scholarship, s.Age, s.Nation, s.Adress.toStr());
                }
            }
            this.dataGridViewStudent.DataSource = table;
        }
        private void showchartTeacher()
        {
            chartTeacher.Series[0].Points.Clear();
            _teacherList = _form1._teacherList;

            for (int i = 0; i < _teacherList.TList.Count(); i++)
            {
                chartTeacher.Series["Student"].Points.AddXY(_teacherList.TList[i].Name + _teacherList.TList[i].Surname, _teacherList.TList[i].LStudents.Count());
            }
        }
        private void showchartStudent()
        {
            chartStudent.Series[0].Points.Clear();
            _teacherList = _form1._teacherList;

            for (int i = 0; i < _teacherList.TList.Count(); i++)
            {
                for (int j = 0; j < _teacherList.TList[i].LStudents.Count; j++)
                {
                    Student s = _teacherList.TList[i].LStudents[j];
                    chartStudent.Series["TermPaper"].Points.AddXY(s.Name + s.Surname, s.LTermPaper.Count());
                }
            }
        }
    }
}
