using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            txtEthiopianDate.Text = SelectedDate.ToEthiopianDateString(textBox4.Text);
        }

        private void EthiopianDateCode_Load(object sender, EventArgs e)
        {

        }
       
    }
}
