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
    public partial class NewTL : Form
    {
        SqlConnection connection;
        public NewTL(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }


        private void NewTL_Load(object sender, EventArgs e)
        {

            //вибір водія для комбобоксу
            string queryV = "SELECT Driver_Code, Full_Name FROM Driver";
            SqlCommand commandV = new SqlCommand(queryV, connection);
            SqlDataReader readerV = commandV.ExecuteReader();

            while (readerV.Read())
            {
                string codDriv = readerV.GetString(0);
                string fullN = readerV.GetString(1);
                comboBox2.Items.Add(codDriv + " - " + fullN);
            }

            readerV.Close();

            //вибір автобуса для комбобоксу
            string queryA = "SELECT Bus_Code, License_Plate_Num FROM Bus";
            SqlCommand commandA = new SqlCommand(queryA, connection);
            SqlDataReader readerA = commandA.ExecuteReader();

            while (readerA.Read())
            {
                string busCode = readerA.GetString(0);
                string licensePlateNum = readerA.GetString(1);
                comboBox1.Items.Add(busCode + " - " + licensePlateNum);
            }

            readerA.Close();

            //вибір рейсу для комбобокусу
            string queryR = "\r\nSELECT Trip.Trip_Code, Direction.Destination, Route_.Distance, Trip.Departure_Time\r\nFROM Route_\r\nINNER JOIN Direction ON Route_.Direction_Code = Direction.Direction_Code\r\nINNER JOIN Trip ON Route_.Route_Code = Trip.Route_Code;";
            SqlCommand commandR = new SqlCommand(queryR, connection);
            SqlDataReader readerR = commandR.ExecuteReader();

            while (readerR.Read())
            {
                string RouteCode = readerR.GetString(0);
                string Destination = readerR.GetString(1);
                int Distance = readerR.GetInt32(2);
                TimeSpan departureTime = readerR.GetTimeSpan(3);

                string formattedDepartureTime = departureTime.ToString(@"hh\:mm");
                string displayText = $"{RouteCode} - {Destination} - {Distance} - {formattedDepartureTime}";

                comboBox3.Items.Add(displayText);
            }

            readerR.Close();

        }



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string TL_num = textBox1.Text;
                DateTime dateOfTL = dateTimePicker1.Value;
                string BusCode = comboBox1.SelectedItem.ToString().Split('-')[0];
                string DrivCode = comboBox2.SelectedItem.ToString().Split('-')[0];
                string TripCode = comboBox3.SelectedItem.ToString().Split('-')[0];

                SqlCommand command = new SqlCommand("INSERT INTO Transport_List (Transport_List_Num, Date_, Bus_Code, Driver_Code, Trip_Code) VALUES (@Transport_List_Num, @Date_, @Bus_Code, @Driver_Code, @Trip_Code);", connection);


                command.Parameters.AddWithValue("@Transport_List_Num",  TL_num);
                command.Parameters.AddWithValue("@Date_", dateOfTL);
                command.Parameters.AddWithValue("@Bus_Code", BusCode);
                command.Parameters.AddWithValue("@Driver_Code", DrivCode);
                command.Parameters.AddWithValue("@Trip_Code", TripCode);
                command.ExecuteNonQuery();
                MessageBox.Show("Дані додано успішно!", "Успіх",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = " ";
            }

            catch (Exception ex)
            {
                MessageBox.Show( "Дані не додано", "Помилка при спробі додати дані!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
