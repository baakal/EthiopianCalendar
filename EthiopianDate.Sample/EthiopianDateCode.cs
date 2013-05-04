using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BaakalDate;

namespace EthiopianDateUserAcceptanceTest
{
    public partial class EthiopianDateCode : Form
    {
        public EthiopianDateCode()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime SelectedDate = dateTimePicker1.Value;
            txtEthiopianShortDate.Text = SelectedDate.ToEthiopianDateString();
            txtEthiopianLongDate.Text = SelectedDate.ToEthiopianLongDateString();
            txtEthiopianDate.Text = SelectedDate.ToEthiopianDateString();
            txtEthiopianDateCustom.Text = SelectedDate.ToEthiopianDateString(textBox4.Text);
            DataTable dt = new DataTable();
            dt.Columns.Add("Date");
            DataRow dr = dt.NewRow();
            dr["date"] = dateTimePicker1.Value;
            dt.Rows.Add(dr);
            dataGridView1.DataSource = dt;

        }

        private void EthiopianDateCode_Load(object sender, EventArgs e)
        {
            DateTime myDT = new DateTime(2002, 4, 3, new GregorianCalendar());
            // Uses the default calendar of the InvariantCulture.
            Calendar myCal = CultureInfo.InvariantCulture.Calendar;

        }
       
    }
}
