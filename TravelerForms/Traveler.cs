﻿using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelerDetailsManagementSystem.TravelerForms
{
    public partial class Traveler : Form
    {
        #region Private Variables

        Traveler objTraveler = new Traveler();

        TravelerBL travelerBL = new TravelerBL();

        List<Traveler> lstTraveler;
        #endregion



        public Traveler()
        {
            InitializeComponent();
        }

        #region ToolBar Methods

        //Save Traveler Details
        private void btnSave_Click(object sender, EventArgs e)
        {

        } 

        #endregion
    }
}
