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
            // Sets starting parameters
            temperature = 30;
            light30.BackColor = Color.LawnGreen;
            spin = 600;
            light600.BackColor = Color.LawnGreen;
            inletvalve = false;
            outletvalve = false;
            countertimer = 0;
            

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;
            timer.Enabled = false;
            timer.Tick += new EventHandler(timer_Tick);

            clothesdetergentBtn.Enabled = false;
        }

        private void startbtn_Click(object sender, EventArgs e)
        {//requests wash to start
            countertimer = 30; 
            timer.Enabled = true;
            doorlock = true;
            timer.Start();
           
         
        }
       public void timer_Tick(object sender, EventArgs e)
        {
            countertimer--;
            timeinfo.Text = countertimer.ToString();
            if (timer.Enabled == true)
            {
                tempbtn.Enabled = false;
                spinbtn.Enabled = false;
                doorbtn.Enabled = false;
            }
            
            if (countertimer <= 30)
            {
                //   washcontroller
                modeinfo.Text = "Washing Cycle";
            }
            if (countertimer <= 20)
            {
                // rinsecontroller
                modeinfo.Text = "Rinsing Cycle";
            }
            if (countertimer <= 10)
            {
                // spincontroller;
                modeinfo.Text = "Spinning Cycle";
            }
            if (countertimer == 0)
            {
                modeinfo.Text = "Run Finished";
                tempbtn.Enabled = true;
                spinbtn.Enabled = true;
                doorbtn.Enabled = true;
                timeinfo.Text = "";
                timer.Enabled = false;
            }
        }

        public void washcontroller (object sender, EventArgs e)
        {
            
            inletvalve = true;
            outletvalve = false;
            modeinfo.Text = " wash cycle is running";

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {   //cancelling any cycle
            modeinfo.Text = "Cycle Cancelled";
            countertimer = 0;
            inletvalve = false;
            outletvalve = true;
            timer.Enabled = false;
            tempbtn.Enabled = true;
            spinbtn.Enabled = true;
            doorbtn.Enabled = true;
            timeinfo.Text = "";
        }


        public void spincontroller(object sender, EventArgs e)
        {
            inletvalve = false;
            outletvalve = true;
            modeinfo.Text = " spin cycle is running";
        }
        public void rinsecontroller(object sender, EventArgs e)
        {
            inletvalve = true;
            outletvalve = false;
            modeinfo.Text = " rinse cycle in progress";

        }
        private void clothesdetergentBtn_Click(object sender, EventArgs e)
        {   //simulating user inputing clothes and detergent
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
        {   // opening the machine door
            if ((door == false) && (clothesanddetergent == false))
            {
                wmachine.Image = Properties.Resources.imgopendoor;
                door = true;
                clothesdetergentBtn.Enabled = true;
                startbtn.Enabled = false;
                modeinfo.Text = "Door Open";
            }
            else if ((door == false) && (clothesanddetergent == true))

            {
                wmachine.Image = Properties.Resources.imgopenwithclothesetc;
                door = true;
                clothesdetergentBtn.Enabled = true;
                startbtn.Enabled = false;
                modeinfo.Text = "Door Open";
            }

            else if ((door == true) && (clothesanddetergent == false))
            {
                wmachine.Image = Properties.Resources.imgdoorclosed;
                door = false;
                clothesdetergentBtn.Enabled = false;
                startbtn.Enabled = true;
                modeinfo.Text = "Door Closed";
                
            }
            else if ((door == true) && (clothesanddetergent == true))
            {
                wmachine.Image = Properties.Resources.imgclosedwashing;
                door = false;
                clothesdetergentBtn.Enabled = false;
                startbtn.Enabled = true;
                modeinfo.Text = "Door Closed";
            }

        }

        private void spinbtn_Click(object sender, EventArgs e)
        {
            // user indicator of spin speeds and current selected spin speed
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
        }

        private void tempbtn_Click(object sender, EventArgs e)
        {
            //user indication of  wash temperature
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
        }
    }
}
