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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusST
{
    public partial class ZvitTL : Form
    {
        SqlConnection connection;
        public ZvitTL(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void ZvitTL_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string queru = "Select * From vw_Transport_List";
            if (textBox1.Text != "")
            {
                queru = "Select * From vw_Transport_List where Full_Name LIKE '" + textBox1.Text + "%'";


            }
            if (checkBox1.Checked)
            {
                queru = queru + " order by Date_";
            }
           
            
            
            SqlDataAdapter adapter = new SqlDataAdapter(queru, connection);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            adapter.Dispose();
            dataSetTLBindingSource.DataSource = ds.Tables[0];



          
            reportViewer1.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
