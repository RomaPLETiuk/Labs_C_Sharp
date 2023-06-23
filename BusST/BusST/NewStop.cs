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
    public partial class NewStop : Form
    {
        SqlConnection connection;
        public NewStop(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void NewStop_Load(object sender, EventArgs e)
        {
            string queryA = "SELECT Route_Code, Route_Number FROM Route_";
            SqlCommand commandA = new SqlCommand(queryA, connection);
            SqlDataReader readerA = commandA.ExecuteReader();

            while (readerA.Read())
            {
                string RouteCode = readerA.GetString(0);
                string RouteNumber = readerA.GetString(1);
                comboBox1.Items.Add(RouteCode + " - " + RouteNumber);
            }

            readerA.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string stopCode = textBox1.Text;
                string stopName = textBox2.Text;
                string routeCode = comboBox1.SelectedItem.ToString().Split('-')[0];

                string sqlInsertStop = "INSERT INTO Stop_ (Stop_Code, Stop_Name) VALUES (@Stop_Code, @Stop_Name)";
                SqlCommand cmdInsertStop = new SqlCommand(sqlInsertStop, connection);
                cmdInsertStop.Parameters.AddWithValue("@Stop_Code", stopCode);
                cmdInsertStop.Parameters.AddWithValue("@Stop_Name", stopName);
                cmdInsertStop.ExecuteNonQuery();

                string sqlInsertStopRoute = "INSERT INTO Stop_Route (Stop_Code, Route_Code) VALUES (@Stop_Code, @Route_Code)";
                SqlCommand cmdInsertStopRoute = new SqlCommand(sqlInsertStopRoute, connection);
                cmdInsertStopRoute.Parameters.AddWithValue("@Stop_Code", stopCode);
                cmdInsertStopRoute.Parameters.AddWithValue("@Route_Code", routeCode);
                cmdInsertStopRoute.ExecuteNonQuery();

                // Повідомити користувача про успішне додавання зупинки
                MessageBox.Show("Зупинку успішно додано до бази даних.", "Повідомлення");

                // Очистити поля введення
                textBox1.Text = "";
                textBox2.Text = "";
                comboBox1.SelectedIndex = -1;



            }

            catch (Exception ex)
            {
                MessageBox.Show(ex +"Дані не додано", "Помилка при спробі додати дані!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
