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
    public partial class NewDriver : Form
    {
        SqlConnection connection;
        public NewDriver(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string driverCode = textBox1.Text;
                string fullName = textBox2.Text;
                DateTime dateOfBirth = dateOfBirthPicker.Value;
                string address = textBox4.Text;
                string driverLicenseNum = textBox5.Text;

                SqlCommand command = new SqlCommand("INSERT INTO Driver (Driver_Code, Full_Name, Date_Of_Birth, Address_, Driver_License_Num) " +
                     "VALUES (@Driver_Code, @Full_Name, @Date_Of_Birth, @Address_, @Driver_License_Num)", connection);
                
                command.Parameters.AddWithValue("@Driver_Code", driverCode);
                command.Parameters.AddWithValue("@Full_Name", fullName);
                command.Parameters.AddWithValue("@Date_Of_Birth", dateOfBirth);
                command.Parameters.AddWithValue("@Address_", address);
                command.Parameters.AddWithValue("@Driver_License_Num", driverLicenseNum);
                command.ExecuteNonQuery();

                MessageBox.Show("Дані додано успішно!", "Успіх",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Text = " ";
                textBox2.Text = " ";
                //textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";

            }

            catch (Exception ex)
            {
                MessageBox.Show("Дані не додано", "Помилка при спробі додати дані!",
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
