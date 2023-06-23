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
    public partial class Form_manag : Form
    {
        SqlConnection connection;
        public Form_manag(SqlConnection connection)
        {
            InitializeComponent();
            this.connection = connection;
        }

        private void вихідToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }


       
        // Додати автобус
        private void додатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewBus  newBus = new NewBus(connection);
            newBus.ShowDialog();
        }

        //Додати напрямок
        private void новийToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            New_Direction new_Direction = new New_Direction(connection);
            new_Direction.ShowDialog();
        }

        //видвлити автобус
        private void змінитиToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            DelBus dlBus = new DelBus(connection); 
            dlBus.ShowDialog();

        }
        //Перегляд автобуса
        private void переглядToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            seeBus seeBus = new seeBus(connection); 
            seeBus.ShowDialog();
        }
        //додати водія
        private void додатиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           NewDriver newDriver = new NewDriver(connection);
            newDriver.ShowDialog();

        }
        //видалити водія
        private void змінитиToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            DelDriv delDriv = new DelDriv(connection);  
            delDriv.ShowDialog();


        }
        // перегляд водія
        private void переглядToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            seeDriv seeDriv = new seeDriv(connection);      
            seeDriv.ShowDialog();
        }

        //новий транспортний лист
        private void новийToolStripMenuItem3_Click(object sender, EventArgs e)
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
        
        //Нова зупинка
        private void новаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewStop newStop = new NewStop(connection);
            newStop.ShowDialog();
        }

        //видалити зупику
        private void змінитиToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DelStop delStop = new DelStop(connection);
            delStop.ShowDialog();
        }

        //видалити напрямок
        private void змінитиToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Del_Direction delDirection = new Del_Direction(connection); 
            delDirection.ShowDialog();

        }

        //новий маршрут
        private void новийToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NewRoute newRoute = new NewRoute(connection);   
            newRoute.ShowDialog();

        }

        //видалити маршрут
        private void змінитиToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DelRoute newD_Route = new DelRoute(connection);
            newD_Route.ShowDialog();

        }

        //новий рейс
        private void новийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewTrip newTrip = new NewTrip(connection);
            newTrip.ShowDialog();

        }
        //видалитит рейс
        private void змінитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelTrip delTrip = new DelTrip(connection);
            delTrip.ShowDialog();
        }

        private void розкладРухуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoportForm_1 roportForm_1 = new RoportForm_1(connection); 
            roportForm_1.ShowDialog();  
        }

        private void транспортнийЛистToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ZvitTL zvitTL = new ZvitTL(connection);
            zvitTL.ShowDialog();
        }

        private void інформаціяПроМаршрутToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zvit_Route route = new Zvit_Route(connection); 
            route.ShowDialog();
        }

        private void інформаціяПроРейсToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Zvit_Trip trip = new Zvit_Trip(connection); 
            trip.ShowDialog();
        }

        private void редагуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RedDriv redDriv = new RedDriv(connection);
            redDriv.ShowDialog();
        }
    }
}
