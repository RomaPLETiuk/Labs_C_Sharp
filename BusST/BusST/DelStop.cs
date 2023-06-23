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
    public partial class DelStop : Form
    {
        SqlConnection connection;
        public DelStop(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void DelStop_Load(object sender, EventArgs e)
        {
            string queryV = "SELECT Stop_Code, Stop_Name FROM Stop_";
            SqlCommand commandV = new SqlCommand(queryV, connection);
            SqlDataReader readerV = commandV.ExecuteReader();

            while (readerV.Read())
            {
                string StopCode = readerV.GetString(0);
                string StopName = readerV.GetString(1);
                comboBox1.Items.Add(StopCode + " - " + StopName);
            }

            readerV.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отримати значення з комбобоксу
            string stopCode = comboBox1.SelectedItem.ToString().Split('-')[0];

            // Виконати SQL запит на видалення зупинки з таблиці Stop_Route
            SqlCommand cmdDeleteStopRoute = new SqlCommand("DELETE FROM Stop_Route WHERE Stop_Code = @Stop_Code", connection);
            cmdDeleteStopRoute.Parameters.AddWithValue("@Stop_Code", stopCode);
            cmdDeleteStopRoute.ExecuteNonQuery();

            // Виконати SQL запит на видалення зупинки з таблиці Stop_
            SqlCommand cmdDeleteStop = new SqlCommand("DELETE FROM Stop_ WHERE Stop_Code = @Stop_Code", connection);
            cmdDeleteStop.Parameters.AddWithValue("@Stop_Code", stopCode);
            cmdDeleteStop.ExecuteNonQuery();

            

            // Повідомити користувача про успішне видалення зупинки
            MessageBox.Show("Зупинку успішно видалено з бази даних.", "Повідомлення");

            // Очистити комбобокс та оновити дані
            comboBox1.SelectedIndex = -1;
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
