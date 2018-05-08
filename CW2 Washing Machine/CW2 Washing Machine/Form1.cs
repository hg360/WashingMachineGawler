using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;


namespace CW2_Washing_Machine
{
    public partial class Form1 : Form
    {

        System.Windows.Forms.Timer timer;
        public int temperature, spin,countertimer ;
        public bool door =false, clothesanddetergent=false, inletvalve=false, outletvalve=false, doorlock=false; 
        public Form1()
        {
            InitializeComponent();
            //initialises 
            temperature = 30;
            light30.BackColor = Color.LawnGreen;
            spin = 600;
            light600.BackColor = Color.LawnGreen;
            tempreadtxt.Text = temperature.ToString();
            speedreadtxt.Text = spin.ToString();
            //tatustxt.Text = spin.ToString();
            inletvalve = false;
            outletvalve = false;
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Enabled = false;
            clothesdetergentBtn.Enabled = false;
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            doorlock = true;
            timer.Start();
            timer.Tick.
            while (countertimer < 10)
            {
             //   washcontroller;
            }
            while (countertimer < 20 && countertimer >10)
            {
               // rinsecontroller;
            }
            while (countertimer < 30 && countertimer > 20)
            {
               // spincontroller;
            }
            if (countertimer > 30)
            {
                countertimer = 0;
            }
        }
        public void TimerTick (object source ,ElapsedEventArgs e)
        {
            countertimer++;
        }

        public void washcontroller (object sender, EventArgs e)
        {
            
            inletvalve = true;
            outletvalve = false;
            cycleinfo.Text = " wash cycle is running";

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            countertimer = 35;
            cycleinfo.Text = "cancled cycle";
            countertimer = 0;
            inletvalve = false;
            outletvalve = true;
        }

        public void spincontroller(object sender, EventArgs e)
        {
            inletvalve = false;
            outletvalve = true;
            cycleinfo.Text = " spin cycle is running";

        }
        public void rinsecontroller(object sender, EventArgs e)
        {
            inletvalve = true;
            outletvalve = false;
            cycleinfo.Text = " rinse cycle is running";

        }
        private void clothesdetergentBtn_Click(object sender, EventArgs e)
        {
            if (clothesanddetergent == false)
            {
                wmachine.Image = Properties.Resources.imgopenwithclothesetc;
                clothesanddetergent = true;
            }
            else if (clothesanddetergent == true)
            {
                wmachine.Image = Properties.Resources.imgopendoor;
                clothesanddetergent = false;
            }
        }

        private void doorbtn_Click(object sender, EventArgs e)
        {
            if ((door == false) && (clothesanddetergent == false))
            {
                wmachine.Image = Properties.Resources.imgopendoor;
                door = true;
                clothesdetergentBtn.Enabled = true;
            }
            else if ((door == false) && (clothesanddetergent == true))

            {
                wmachine.Image = Properties.Resources.imgopenwithclothesetc;
                door = true;
                clothesdetergentBtn.Enabled = true;
            }

            else if ((door == true) && (clothesanddetergent == false))
            {
                wmachine.Image = Properties.Resources.imgdoorclosed;
                door = false;
                clothesdetergentBtn.Enabled = false;
            }
            else if ((door == true) && (clothesanddetergent == true))
            {
                wmachine.Image = Properties.Resources.imgclosedwashing;
                door = false;
                clothesdetergentBtn.Enabled = false;
            }
        }

        private void spinbtn_Click(object sender, EventArgs e)
        {

            if (spin == 800)
            {
                light1200.BackColor = Color.LawnGreen;
                spin = 1200;
                light800.BackColor = default(Color);
            }


            else if (spin == 600)
            {
                light800.BackColor = Color.LawnGreen;
                spin = 800;
                light600.BackColor = default(Color);
            }
            else if (spin == 1200)
            {
                light600.BackColor = Color.LawnGreen;
                spin = 600;
                light1200.BackColor = default(Color);
            }
            speedreadtxt.Text = spin.ToString();
           //tatustxt.Text = spin.ToString();
        }

        private void tempbtn_Click(object sender, EventArgs e)
        {

            if (temperature == 40)
            {
                light60.BackColor = Color.LawnGreen;
                temperature = 60;
                light40.BackColor = default(Color);
            }


            else if (temperature == 30)
            {
                light40.BackColor = Color.LawnGreen;
                temperature = 40;
                light30.BackColor = default(Color);
            }
            else if (temperature == 60)
            {
                light30.BackColor = Color.LawnGreen;
                temperature = 30;
                light60.BackColor = default(Color);
            }

           tempreadtxt.Text = temperature.ToString() ;
        }
    }
}
