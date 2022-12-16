using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string _title = textBox_title.Text;
            string _description = textBox_description.Text;
            DateTime _deadline = DateTime.Parse(dateTimePicker_deadline.Text);


        }
    }
}
