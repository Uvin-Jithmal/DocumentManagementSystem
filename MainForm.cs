using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelerDetailsManagementSystem.MealMasterfile;
using TravelerDetailsManagementSystem.TravelerForms;

namespace TravelerDetailsManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Thread trd = new Thread(new ThreadStart(formRun));
            trd.Start();
            Thread.Sleep(3000);
            InitializeComponent();
            trd.Abort();
        }
        private void formRun()
        {
            Application.Run(new SplashScreen());
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Traveler frmTravel = new Traveler();
            frmTravel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Meal frmMeal = new Meal();
            frmMeal.Show();

            //this.Close();

            //MainForm frmMain = new MainForm();
            //frmMain.Close();
        }
    }
}
