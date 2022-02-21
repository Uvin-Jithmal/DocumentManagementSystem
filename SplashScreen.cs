﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelerDetailsManagementSystem
{
    public partial class SplashScreen : Form
    {
        //Private Variables
        Timer tmr;
        int move = 2;
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Shown(object sender, EventArgs e)
        {
            tmr = new Timer();

            //set time interval 3 sec
            tmr.Interval = 5000;
            //starts the timer
            tmr.Start();
            tmr.Tick += tmr_Tick;

        }
        void tmr_Tick(object sender, EventArgs e)

        {

            //after 3 sec stop the timer
            tmr.Stop();
            //display mainform
            MainForm mf = new MainForm();
            mf.Show();
            //hide this form
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelSlide.Left += 2;
            if (panelSlide.Left > 450)
            {
                panelSlide.Left = 0;
               
            }
            if (panelSlide.Left < 0)
            {

                move = 2;
               
            }
        }
    }
}