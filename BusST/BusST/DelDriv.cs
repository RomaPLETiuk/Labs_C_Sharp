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
    public partial class DelDriv : Form
    {
        
        SqlConnection connection;
        public DelDriv(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }
        private void DelDriv_Load(object sender, EventArgs e)
        {
            string query = "SELECT Driver_Code, Full_Name FROM Driver";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                string item = string.Format("{0} ({1})", reader.GetString(0), reader.GetString(1));
                comboBox1.Items.Add(item);
            }

            reader.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedDriv = comboBox1.SelectedItem.ToString();
            string selectedDriver_Code = selectedDriv.Split(' ')[0];

            // Видалення автобуса з таблиці Bus
            string deleteQuery = "DELETE FROM Driver WHERE Driver_Code = @Driver_Code";
            SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
            deleteCommand.Parameters.AddWithValue("@Driver_Code", selectedDriver_Code);

            // Підтвердження видалення
            DialogResult result = MessageBox.Show("Ви впевнені, що хочете звільнити такого прекрасного водія?", "Підтвердження видалення", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                deleteCommand.ExecuteNonQuery();
                MessageBox.Show("Водія звільнено успішно!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
