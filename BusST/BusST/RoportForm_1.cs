using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusST
{
    public partial class RoportForm_1 : Form
    {
        SqlConnection connection;
        public RoportForm_1(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void RoportForm_1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet11.vw_Timetable". При необходимости она может быть перемещена или удалена.
            this.vw_TimetableTableAdapter.Fill(this.dataSet11.vw_Timetable);


            this.reportViewer1.RefreshReport();
            
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string queru = "Select * From vw_Timetable order by Departure_Time";
            if(textBox1.Text != "")
            {
                queru = "Select * From vw_Timetable where Destination LIKE '" + textBox1.Text + "%'";


            }
            //SqlCommand command = new SqlCommand("Select * From vw_Timetable", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(queru, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            adapter.Dispose();
            vwTimetableBindingSource.DataSource = ds.Tables[0];



            //DataTable dt = new DataTable();
            //adapter.Fill(dt);

            //reportViewer1.LocalReport.DataSources.Clear();
            //ReportDataSource source = new ReportDataSource("DataSet1", dt);
            //reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            //reportViewer1.LocalReport.DataSources.Add(source);
            reportViewer1.RefreshReport();

        }

        private void reportViewer1_Load_1(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
