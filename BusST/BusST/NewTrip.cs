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
    public partial class NewTrip : Form
    {
        SqlConnection connection;
        public NewTrip(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void NewTrip_Load(object sender, EventArgs e)
        {
            //вибір рейсу для комбобокусу
            string queryR = "\r\nSELECT Route_.Route_Code, Direction.Destination, Route_.Distance\r\nFROM Route_\r\nINNER JOIN Direction ON Route_.Direction_Code = Direction.Direction_Code;";
            SqlCommand commandR = new SqlCommand(queryR, connection);
            SqlDataReader readerR = commandR.ExecuteReader();

            while (readerR.Read())
            {
                string RouteCode = readerR.GetString(0);
                string Destination = readerR.GetString(1);
                int Distance = readerR.GetInt32(2);
               // TimeSpan departureTime = readerR.GetTimeSpan(3);

                //string formattedDepartureTime = departureTime.ToString(@"hh\:mm");
                string displayText = $"{RouteCode} - {Destination} - {Distance}";

                comboBox1.Items.Add(displayText);
            }

            readerR.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string TripCode = maskedTextBox1.Text;
                string RouteCode = comboBox1.SelectedItem.ToString().Split('-')[0];
                DateTime Departure_Time = dateTimePicker1.Value;
                DateTime Arrival_Time = dateTimePicker2.Value;


                SqlCommand command = new SqlCommand("EXECUTE AddTrip @Trip_Code, @Route_Code , @Departure_Time , @Arrival_Time ;", connection);


                command.Parameters.AddWithValue("@Trip_Code", TripCode);
                command.Parameters.AddWithValue("@Route_Code", RouteCode);
                command.Parameters.AddWithValue("@Departure_Time", Departure_Time);
                command.Parameters.AddWithValue("@Arrival_Time", Arrival_Time);
                
                command.ExecuteNonQuery();
                MessageBox.Show("Дані додано успішно!", "Успіх",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                maskedTextBox1.Text = " ";
                comboBox1.SelectedIndex = -1;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex + "Дані не додано", "Помилка при спробі додати дані!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   

        }

        
    }
}
