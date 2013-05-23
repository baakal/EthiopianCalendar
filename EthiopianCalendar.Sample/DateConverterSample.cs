using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EthiopianCalendar.Sample
{
    public partial class DateConverterSample : Form
    {
        public DateConverterSample()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string format = txtFormat.Text;
            DateTime currentDate = dtpFrom.Value;
            DateTime endingDate = dtpTo.Value;
            if(currentDate> endingDate)
            {
                MessageBox.Show(this, "Starting Date is Greater then ending date");
                return;
            }
            DataTable dataTable = new DataTable("MyTable");
            dataTable.Columns.Add("GregorianDate");
            dataTable.Columns.Add("EthiopianDate");
            dataTable.NewRow();
            while(currentDate < endingDate)
            {
                DataRow dataRow = dataTable.NewRow();
                dataRow["GregorianDate"] = currentDate.ToLongDateString();
                dataRow["EthiopianDate"] = currentDate.ToEthiopianDateString(format);
                dataTable.Rows.Add(dataRow);
                currentDate = currentDate.AddDays(1);
            }
            gridSample.DataSource = dataTable;
        }

        private void DateConverterSample_Load(object sender, EventArgs e)
        {

        }

      
    }
}
