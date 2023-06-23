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
    public partial class Del_Direction : Form
    {
        SqlConnection connection;
        public Del_Direction(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void Del_Direction_Load(object sender, EventArgs e)
        {
            string query = "SELECT Direction_Code, Destination FROM Direction";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string directionCode = reader.GetString(0);
                string destination = reader.GetString(1);
                comboBox1.Items.Add(directionCode + " - " + destination);
            }
            reader.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string directionCode = comboBox1.SelectedItem.ToString().Split(' ')[0];

            // видалення записів з таблиць Route_, Trip та Transport_List, пов'язаних з обраним напрямком
            string deleteQuery = "DELETE FROM Route_ WHERE Direction_Code = @directionCode";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
            deleteCommand.Parameters.AddWithValue("@directionCode", directionCode);
            deleteCommand.ExecuteNonQuery();

            deleteQuery = "DELETE FROM Trip WHERE Route_Code NOT IN (SELECT Route_Code FROM Route_)";
            deleteCommand = new SqlCommand(deleteQuery, connection);
            deleteCommand.ExecuteNonQuery();

            deleteQuery = "DELETE FROM Transport_List WHERE Trip_Code NOT IN (SELECT Trip_Code FROM Trip)";
            deleteCommand = new SqlCommand(deleteQuery, connection);
            deleteCommand.ExecuteNonQuery();

            // видалення запису з таблиці Direction
            deleteQuery = "DELETE FROM Direction WHERE Direction_Code = @directionCode";
            deleteCommand = new SqlCommand(deleteQuery, connection);
            deleteCommand.Parameters.AddWithValue("@directionCode", directionCode);
           

            // Підтвердження видалення
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей напрямок?", "Підтвердження видалення", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("напрямок видалено успішно!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
