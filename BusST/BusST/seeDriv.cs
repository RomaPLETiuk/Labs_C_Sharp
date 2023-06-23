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
    public partial class seeDriv : Form
    {
        SqlConnection connection;
        public seeDriv(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void seeDriv_Load(object sender, EventArgs e)
        {
            string query = "SELECT Driver_Code, Full_Name FROM Driver";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string codDriv = reader.GetString(0);
                string fullN = reader.GetString(1);
                comboBox1.Items.Add(codDriv + " - " + fullN);
            }

            reader.Close();

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string selectedDriv = comboBox1.SelectedItem.ToString();
            string[] drivInfo = selectedDriv.Split('-');
            string CodeDR = drivInfo[0].Trim();

            string query = "SELECT * FROM Driver WHERE Driver_Code = @CodeDR";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CodeDR", CodeDR);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                
                textBox1.Text = reader.GetString(0);  // code
                textBox2.Text = reader.GetString(1);  // Name
                dateTimePicker1.Value = reader.GetDateTime(2);  // Year of B
                textBox4.Text = reader.GetString(3);  // adress
                textBox5.Text = reader.GetString(4);  // licens
            }

            reader.Close();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
