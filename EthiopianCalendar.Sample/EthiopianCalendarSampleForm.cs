using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EthiopianCalendar.Sample
{
    public partial class EthiopianCalendarSampleForm : Form
    {
        public EthiopianCalendarSampleForm()
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

            EthiopianDate ethiopianDate = SelectedDate.ToEthiopianDate();
            txtGreg.Text = ethiopianDate.ToGregorianDate().ToLongDateString();
            
        }

        private void EthiopianDateCode_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            DateConverterSample dateConverterSample = new DateConverterSample();
            dateConverterSample.ShowDialog(this);

        }
       
    }
}
