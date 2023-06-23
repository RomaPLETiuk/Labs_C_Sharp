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
    public partial class DelBus : Form
    {
        SqlConnection connection;
        public DelBus(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void DelBus_Load(object sender, EventArgs e)
        {
            string query = "SELECT License_Plate_Num, Model FROM Bus";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string item = string.Format("{0} ({1})", reader.GetString(0), reader.GetString(1));
                comboBox1.Items.Add(item);
            }

            reader.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedBus = comboBox1.SelectedItem.ToString();
            string selectedLicensePlateNum = selectedBus.Split(' ')[0];

            // Видалення автобуса з таблиці Bus
            string deleteQuery = "DELETE FROM Bus WHERE License_Plate_Num = @License_Plate_Num";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
            deleteCommand.Parameters.AddWithValue("@License_Plate_Num", selectedLicensePlateNum);

            // Підтвердження видалення
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете видалити цей автобус?", "Підтвердження видалення", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Автобус видалено успішно!");
            }

        }

        
    }
}
