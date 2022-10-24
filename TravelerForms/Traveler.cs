using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelerClasses.Customer;
using TravelerDetailsManagementSystem.Common;

namespace TravelerDetailsManagementSystem.TravelerForms
{
    public partial class Traveler : Form
    {
        #region Private Variables

        TravelerClass objTraveler = new TravelerClass();

        TravelerBL travelerBL = new TravelerBL();

        List<Traveler> lstTraveler;
        #endregion



        public Traveler()
        {
            InitializeComponent();
            comboTravelOtherPlace.Visible = false;
            txtOtherPlaces.Visible = false;
            txtOtherNotes.Visible = false;
        }

        #region ToolBar Methods

        //Save Traveler Details
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                #region TextBox Validations

                if (string.IsNullOrWhiteSpace(txtTravelerName.Text))
                {
                    CommonModule.ShowWarningMessage("Please Enter Traveler Name");
                }
                else if (string.IsNullOrWhiteSpace(txtPhone.Text))
                {
                    CommonModule.ShowWarningMessage("Please Enter Traveler PhoneNo");
                }
                else if (string.IsNullOrWhiteSpace(txtTownName.Text))
                {
                    CommonModule.ShowWarningMessage("Please Enter Traveler Town");
                }
                else if (string.IsNullOrWhiteSpace(dtpFrom.Text))
                {
                    CommonModule.ShowWarningMessage("Please Enter Date From");
                }
                else if (string.IsNullOrWhiteSpace(dtpTo.Text))
                {
                    CommonModule.ShowWarningMessage("Please Enter Date To");
                }
                else if (string.IsNullOrWhiteSpace(txtNON.Text))
                {
                    CommonModule.ShowWarningMessage("Please Enter No of Nights");
                }
                else if (string.IsNullOrWhiteSpace(comboRoomType.Text))
                {
                    CommonModule.ShowWarningMessage("Please Select Room Type");
                }
                else if (string.IsNullOrWhiteSpace(comboVehicleType.Text))
                {
                    CommonModule.ShowWarningMessage("Please Select Vehicle Type");
                }
                else if (string.IsNullOrWhiteSpace(txtAmount.Text))
                {
                    CommonModule.ShowWarningMessage("Please Enter Total Amount");
                } 
                #endregion

                else
                {
                    objTraveler.TravelerName = txtTravelerName.Text;
                    objTraveler.PhoneNumber = txtPhone.Text;                 
                    if (!CommonModule.ValidateEmailAddress(txtEmail.Text))
                    {
                        throw new ApplicationException("Please Enter Valid Email Address");
                    }
                    else
                    {
                        objTraveler.Email = txtEmail.Text;
                    }                   
                    objTraveler.Country = txtCountry.Text;
                    objTraveler.TownID = Convert.ToInt32(lblTownID.Text);
                    objTraveler.DateFrom = Convert.ToDateTime(dtpFrom.Text);
                    objTraveler.DateTo = Convert.ToDateTime(dtpTo.Text);
                    objTraveler.NoOfMembers = Convert.ToInt32(txtNOM.Text);
                    objTraveler.NoOfNights = Convert.ToInt32(txtNON.Text);
                    objTraveler.RoomTypeID = Convert.ToInt32(comboRoomType.Text);
                    //objTraveler.RoomTypeID = (int)comboRoomType.SelectedValue;
                    objTraveler.VehicleType = comboVehicleType.Text;
                    objTraveler.Amount = Convert.ToDecimal(txtAmount.Text);

                    if(radioCelebrity.Checked == true)
                    {
                        objTraveler.SpecialNotes = "Celebrity";
                    }
                    else if(radioExcelentCus.Checked == true)
                    {
                        objTraveler.SpecialNotes = "Excelent Customer";
                    }
                    else if (radioBad.Checked == true)
                    {
                        objTraveler.SpecialNotes = "Bad Behaviour";
                    }
                    else if (radioOthernotes.Checked == true)
                    {                       
                        objTraveler.SpecialNotes = txtOtherNotes.Text;
                    }

                    objTraveler.EnteredOn = DateTime.Now;


                    int recID = travelerBL.InsertTravelerDetails(objTraveler);
                    if (recID > 0)
                    {
                        MessageBox.Show("Record ID " + recID.ToString() + " Record(s) Saved Successfully", "Successful");
                        CommonModule.ClearControlsOftheForm(this);
                        //GetEmployees();
                    }
                }
            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }
        #endregion

        private void Traveler_Load(object sender, EventArgs e)
        {

        }

        #region Visible TextBoxes when Radio Checked

        //Special Notes
        private void radioOthernotes_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherNotes.Visible = true;
        }
        private void radioCelebrity_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherNotes.Visible = false;
        }
        private void radioExcelentCus_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherNotes.Visible = false;
        }
        private void radioBad_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherNotes.Visible = false;
        }

        //Purpose
        private void radioOther_CheckedChanged(object sender, EventArgs e)
        {
            txtOtherPlaces.Visible = true;
            comboTravelOtherPlace.Visible = false;
        }
        private void radioTravelOtherPlace_CheckedChanged(object sender, EventArgs e)
        {
            comboTravelOtherPlace.Visible = true;
            txtOtherPlaces.Visible = false;
        }
        private void radioJustVisit_CheckedChanged(object sender, EventArgs e)
        {
            comboTravelOtherPlace.Visible = false;
            txtOtherPlaces.Visible = false;
        }



        #endregion

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
