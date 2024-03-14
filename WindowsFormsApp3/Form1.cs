using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;

            //empezamos por el primer dia del mes.

            DateTime startofthemonth = new DateTime(now.Year, now.Month, 1);
            //
            int days = DateTime.DaysInMonth(now.Year, now.Month);
            //
            int dayoftheweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"));

            //Crearemos un blank usercontrol
            for (int i = 1; i <= dayoftheweek; i++) 
            {
                UserControlBlank ucBlank = new UserControlBlank(); 
                daycontainer.Controls.Add(ucBlank);
            }
            // 
            for (int i = 1;i <= days; i++)
            {
                UserControlDays ucdays = new UserControlDays();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }
    }
}
