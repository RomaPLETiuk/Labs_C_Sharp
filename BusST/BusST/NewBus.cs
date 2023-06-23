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
using System.Windows.Forms.VisualStyles;

namespace BusST
{
    public partial class NewBus : Form
    {
        public NewBus()
        {
            InitializeComponent();
        }

         SqlConnection connection;

        public NewBus(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("INSERT INTO Bus (Bus_Code, Number, Model, License_Plate_Num, Year_Of_Manufacture, Number_of_seats) VALUES (@Bus_Code, @Number, @Model, @License_Plate_Num, @Year_Of_Manufacture, @Number_of_seats)", connection);
                command.Parameters.AddWithValue("@Bus_Code", maskedTextBox1.Text);
                command.Parameters.AddWithValue("@Number", Number.Text);
                command.Parameters.AddWithValue("@Model", Model.Text);
                command.Parameters.AddWithValue("@License_Plate_Num", Nomer.Text);
                command.Parameters.AddWithValue("@Year_Of_Manufacture", Year.Text);
                command.Parameters.AddWithValue("@Number_of_seats", C_Seat.Text);
                command.ExecuteNonQuery();

                MessageBox.Show("Дані додано успішно!", "Успіх",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

                maskedTextBox1.Text = "";
                Number.Text = "";
                Model.Text = "";
                Nomer.Text = "";
                Year.Text = "";
                C_Seat.Text = "";
            }

            catch (Exception ex)
            {
                MessageBox.Show( "Дані не додано", "Помилка при спробі додати дані!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
