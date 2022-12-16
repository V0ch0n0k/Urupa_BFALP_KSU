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
    public partial class FormAddTeacher : Form
    {
        private Form1 _form1;
        public FormAddTeacher(Form1 _form1)
        {
            this._form1 = _form1;
            InitializeComponent();
            labelMessage.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox_name.Text;
            string surname = textBox_surname.Text;
            int age = 0; int.TryParse(textBox_age.Text, out age);
            Nation nation; Enum.TryParse(textBox_nation.Text, out nation);
            string country = textBox_country.Text;
            string city = textBox_city.Text;
            string street = textBox_street.Text;
            int house = 0; int.TryParse(textBox_house.Text, out house);

            string discipline = textBox_discipline.Text;
            int salary = 0; int.TryParse(textBox_salary.Text, out salary);

            if (
                string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(surname))
            {labelMessage.Text = "Не коректні данні"; return; }
            
                _form1._teacherList.add(new Teacher(name, surname, age, nation, new Adress_Class(country, city, street, house), discipline, salary));
                _form1.showTeachers();
            labelMessage.Text = "";
        }
    }
}
