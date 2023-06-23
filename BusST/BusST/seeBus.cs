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
    public partial class seeBus : Form
    {
        SqlConnection connection;
        public seeBus(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void seeBus_Load(object sender, EventArgs e)
        {

            string query = "SELECT Bus_Code, License_Plate_Num FROM Bus";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string busCode = reader.GetString(0);
                string licensePlateNum = reader.GetString(1);
                comboBox1.Items.Add(busCode + " - " + licensePlateNum);
            }

            reader.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedBus = comboBox1.SelectedItem.ToString();
            string[] busInfo = selectedBus.Split('-');
            string busCode = busInfo[0].Trim();

            string query = "SELECT * FROM Bus WHERE Bus_Code = @Bus_Code";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Bus_Code", busCode);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                //textBox1.Text = reader.GetString(0);  // Bus_Code
                textBox1.Text = reader.GetString(1);  // Number
                textBox2.Text = reader.GetString(2);  // Model
                textBox3.Text = reader.GetString(3);  // License_Plate_Num
                textBox4.Text = reader.GetInt32(4).ToString();  // Year_Of_Manufacture
                textBox5.Text = reader.GetInt32(5).ToString();  // Number_of_seats
            }

            reader.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
