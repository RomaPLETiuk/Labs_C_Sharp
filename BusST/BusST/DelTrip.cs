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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace BusST
{
    public partial class DelTrip : Form
    {
        SqlConnection connection;
        public DelTrip(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void DelTrip_Load(object sender, EventArgs e)
        {

            
            //вибір рейсу для комбобокусу
            string queryR = "\r\nSELECT Trip.Trip_Code, Direction.Destination, Route_.Distance, Trip.Departure_Time\r\nFROM Route_\r\nINNER JOIN Direction ON Route_.Direction_Code = Direction.Direction_Code\r\nINNER JOIN Trip ON Route_.Route_Code = Trip.Route_Code;";
            SqlCommand commandR = new SqlCommand(queryR, connection);
            SqlDataReader readerR = commandR.ExecuteReader();

            while (readerR.Read())
            {
                string TripCode = readerR.GetString(0);
                string Destination = readerR.GetString(1);
                int Distance = readerR.GetInt32(2);
                TimeSpan departureTime = readerR.GetTimeSpan(3);

                string formattedDepartureTime = departureTime.ToString(@"hh\:mm");
                string displayText = $"{TripCode} - {Destination} - {Distance} км. - {formattedDepartureTime}";

                comboBox1.Items.Add(displayText);
            }

            readerR.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tripCode = comboBox1.SelectedItem.ToString().Split(' ')[0];

            

            // видалення запису з таблиці route
            string deleteQuery = "DELETE FROM Trip WHERE Trip_Code = @tripCode";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
            deleteCommand.Parameters.AddWithValue("@tripCode", tripCode);


            // Підтвердження видалення
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей Рейс?", "Підтвердження видалення", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Рейс видалено успішно!");
            }

            comboBox1.SelectedIndex = -1;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
