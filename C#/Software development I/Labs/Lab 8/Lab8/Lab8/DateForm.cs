using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class DateForm : Form
    {
        private Date d1 = new Date(1,1,2020);

        public DateForm()
        {
            InitializeComponent();

        }

        private void btnMonth_Click(object sender, EventArgs e)
        {
            int month;
            if (int.TryParse(iptMonth.Text, out month))
            {
                d1.Month = month;
                optDate.Text = d1.ToString();
            }
            else
                MessageBox.Show("Enter an integer!");
        }

        private void DateForm_Load(object sender, EventArgs e)
        {
            optDate.Text = $"{d1}";
        }

        private void btnDay_Click(object sender, EventArgs e)
        {
            int day;
            if (int.TryParse(iptDay.Text, out day))
            {
                d1.Day = day;
                optDate.Text = d1.ToString();
            }
            else
                MessageBox.Show("Enter an integer!");
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            int year;
            if (int.TryParse(iptYear.Text, out year))
            {
                d1.Year = year;
                optDate.Text = d1.ToString();
            }
            else
                MessageBox.Show("Enter an integer!");
        }
    }
}
