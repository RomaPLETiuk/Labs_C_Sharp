using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;

using System.Data.OleDb;

namespace BusST

{
    public partial class Main : Form
    {
        public Main()
        {

            InitializeComponent();
            pass.UseSystemPasswordChar = true;

        }


        public void SplitLine(string line, char delimiter, ref string first_part, ref string last_part)
        {
            int pos = line.IndexOf(delimiter);
            if (pos == -1)
            {
                first_part = "";
                last_part = "";
                return;
            }
            first_part = line.Substring(0, pos).Trim();
            last_part = line.Substring(pos + 1).Trim();
        }
        public string ComposeConnectionString(string StringFromWizard, string UserID, string Pass)
        {
            string Provider="", Password="", Persist_Security_Info="", User_ID ="", Initial_Catalog="", Data_Source="";
            string ConnStr, tmp = "", tmp1;
            SplitLine(StringFromWizard, ';', ref Provider, ref tmp);
            if (tmp.IndexOf("Password=") != -1)
            {
                SplitLine(tmp, ';', ref Password, ref tmp);
            }
            SplitLine(tmp, ';', ref Persist_Security_Info, ref tmp);
            SplitLine(tmp, ';', ref User_ID, ref tmp);
            SplitLine(tmp, ';', ref Initial_Catalog, ref Data_Source);
            User_ID = "User ID=" + UserID;
            Password = "Password=" + Pass;
            ConnStr = Provider + ";" + Password + ";" + Persist_Security_Info + ";" + User_ID + ";" + Initial_Catalog + ";" + Data_Source;
            return ConnStr;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            { 
                pass.UseSystemPasswordChar = false;
            }
            else {
                pass.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string CS="", csnew;
            if (!DataModule.GetConnectionString(ref CS))
            {
                MessageBox.Show("Не знайдений файл з параметрами зв’язку", "Помилка авторизації!",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            
          
                csnew = ComposeConnectionString(CS, loginn.Text, pass.Text);
            
             SqlConnection connection = new SqlConnection(csnew);
            try
                {
                string f = "";
                connection.Open();
                SqlCommand command = new SqlCommand($"SELECT Form FROM Users WHERE Username = '{loginn.Text}'", connection);
                f = command.ExecuteScalar().ToString();

                //string formName = "Form_despehc";
                Type formType = Type.GetType($"BusST.{f}");
                Form form = (Form)Activator.CreateInstance(formType, connection);
                form.ShowDialog();

                



            }
            catch (Exception ex)
                {
                    MessageBox.Show(ex + "Ім'я користувача або пароль введено невірно!", "Помилка авторизації!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            


        }
    }
}
