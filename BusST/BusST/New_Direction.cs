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
    public partial class New_Direction : Form
    {
        SqlConnection connection;

        public New_Direction(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;

            //string query = "SELECT District_Code FROM District";

            //SqlCommand command = new SqlCommand(query, connection);

            //SqlDataReader reader = command.ExecuteReader();

            //// Додавання значень до ComboBox
            //while (reader.Read())
            //{
            //    comboBox_codeDist.Items.Add(reader.GetString(0));
            //}
            //reader.Close();

            string query = "SELECT District_Code, District_Name FROM District";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string districtCode = reader.GetString(0);
                string districtName = reader.GetString(1);
                comboBox_codeDist.Items.Add($"{districtCode} - {districtName}");
            }

            reader.Close();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            //string directionCode = Code_Dir.Text;
            //string destination = Destination.Text;
            //string districtCode = comboBox_codeDist.SelectedItem.ToString();

            //string insertQuery = "INSERT INTO Direction (Direction_Code, Destination, District_Code) " +
            //                     "VALUES (@Direction_Code, @Destination, @District_Code)";
            //SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
            //insertCommand.Parameters.AddWithValue("@Direction_Code", directionCode);
            //insertCommand.Parameters.AddWithValue("@Destination", destination);
            //insertCommand.Parameters.AddWithValue("@District_Code", districtCode);

            //insertCommand.ExecuteNonQuery();
            try
            {
                string directionCode = Code_Dir.Text;
            string destination = Destination.Text;
            string districtCode = comboBox_codeDist.SelectedItem.ToString().Split(' ')[0];

            string insertQuery = "INSERT INTO Direction (Direction_Code, Destination, District_Code) " +
                                 "VALUES (@Direction_Code, @Destination, @District_Code)";
            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
            insertCommand.Parameters.AddWithValue("@Direction_Code", directionCode);
            insertCommand.Parameters.AddWithValue("@Destination", destination);
            insertCommand.Parameters.AddWithValue("@District_Code", districtCode);

            insertCommand.ExecuteNonQuery();
                MessageBox.Show("Дані додано успішно!", "Успіх",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                Code_Dir.Text = "";
                Destination.Text =  "";

            }

            catch (Exception ex)
            {
                MessageBox.Show("Дані не додано", "Помилка при спробі додати дані!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }



        }

        private void New_Direction_Load(object sender, EventArgs e)
        {

        }
    }
}
