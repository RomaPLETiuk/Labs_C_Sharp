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
    public partial class Form_despehc : Form
    {
        SqlConnection connection;
        public Form_despehc(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void Form_despehc_Load(object sender, EventArgs e)
        {

        }

        private void напрямокToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //перегляд автобуса
        private void переглядToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            seeBus seeBus = new seeBus(connection);
            seeBus.ShowDialog();
        }

        //новий ТЛ
        private void новийToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            NewTL newTL = new NewTL(connection);
             newTL.ShowDialog();

        }

        //завантажити ТЛ
        private void переглядToolStripMenuItem7_Click(object sender, EventArgs e)
        {
            seeTL seeTL = new seeTL(connection);    
            seeTL.ShowDialog();
            
        }

        private void розкладРухуToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RoportForm_1 roportForm_1 = new RoportForm_1(connection);
            roportForm_1.ShowDialog();
        }

        private void транспортнийЛистToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ZvitTL zvitTL = new ZvitTL(connection);
                zvitTL.ShowDialog();
        }

        private void інформаціяПроМаршрутToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Zvit_Route route = new Zvit_Route(connection);
            route.ShowDialog();
        }

        private void інформаціяПроРейсToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Zvit_Trip trip = new Zvit_Trip(connection);
            trip.ShowDialog();
        }

        //перегляд водія
        private void переглядToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            seeDriv seeDriv = new seeDriv(connection);
            seeDriv.ShowDialog();
        }
    }
}
