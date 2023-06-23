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
    public partial class DelRoute : Form
    {
        SqlConnection connection;
        public DelRoute(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;   
        }

        private void DelRoute_Load(object sender, EventArgs e)
        {
            string query = "SELECT Route_Code, Route_Number FROM Route_";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string routeCode = reader.GetString(0);
                string routeNumber = reader.GetString(1);
                comboBox1.Items.Add(routeCode + " - " + routeNumber);
            }
            reader.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string routeCode = comboBox1.SelectedItem.ToString().Split(' ')[0];

            //// видалення записів з таблиць Route_, Trip та Transport_List, пов'язаних з обраним напрямком
            //string deleteQuery = "DELETE FROM Route_ WHERE Direction_Code = @directionCode";
            //SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
            //deleteCommand.Parameters.AddWithValue("@directionCode", routeCode);
            //deleteCommand.ExecuteNonQuery();

            //deleteQuery = "DELETE FROM Trip WHERE Route_Code NOT IN (SELECT Route_Code FROM Route_)";
            //deleteCommand = new SqlCommand(deleteQuery, connection);
            //deleteCommand.ExecuteNonQuery();

            //deleteQuery = "DELETE FROM Transport_List WHERE Trip_Code NOT IN (SELECT Trip_Code FROM Trip)";
            //deleteCommand = new SqlCommand(deleteQuery, connection);
            //deleteCommand.ExecuteNonQuery();

            // видалення запису з таблиці route
            string deleteQuery = "DELETE FROM Route_ WHERE Route_Code = @routeCode";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
            deleteCommand.Parameters.AddWithValue("@routeCode", routeCode);


            // Підтвердження видалення
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей Маршрут?", "Підтвердження видалення", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Маршрут видалено успішно!");
            }

            comboBox1.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
