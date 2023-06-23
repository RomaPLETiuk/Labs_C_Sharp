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
    public partial class NewRoute : Form
    {
        SqlConnection connection;
        public NewRoute(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void NewRoute_Load(object sender, EventArgs e)
        {

            string query = "SELECT Direction_Code, Destination FROM Direction";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string Direction_Code = reader.GetString(0);
                string Destination = reader.GetString(1);
                comboBox1.Items.Add($"{Direction_Code} - {Destination}");
            }

            reader.Close();

        }



        

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                string codeRoute = textBox1.Text;                
                string directionCode = comboBox1.SelectedItem.ToString().Split(' ')[0];
                string routeNumber = textBox3.Text; 
                string distance = textBox2.Text;

                string insertQuery = "INSERT INTO Route_ (Route_Code, Distance, Direction_Code, Route_Number ) " +
                                 "VALUES (@Route_Code, @Distance, @Direction_Code, @Route_Number)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@Route_Code", codeRoute);
                insertCommand.Parameters.AddWithValue("@Distance", distance);
                insertCommand.Parameters.AddWithValue("@Direction_Code", directionCode);
                insertCommand.Parameters.AddWithValue("@Route_Number", routeNumber);

                insertCommand.ExecuteNonQuery();
                MessageBox.Show("Дані додано успішно!", "Успіх",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                comboBox1.SelectedIndex = -1;

            }

            catch (Exception ex)
            {
                MessageBox.Show("Дані не додано", "Помилка при спробі додати дані!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }



        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
