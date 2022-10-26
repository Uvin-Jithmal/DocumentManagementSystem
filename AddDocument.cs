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
using TravelerClasses.OutgoingClasses;
using TravelerDetailsManagementSystem.Common;

namespace TravelerDetailsManagementSystem
{
    public partial class AddDocument : Form
    {
        #region Private Variables

        string HRDocaPath;
        string ITDocaPath;
        string FinanceDocaPath;
        string PersonalDocaPath;

        HrDocClass ObjhrDocClass = new HrDocClass();
        ItDocClasses ObjItDocClass = new ItDocClasses();
        FinanceDocClasses ObjFinanceDocClass = new FinanceDocClasses();
        PersonalDocClasses ObjPersonalDocClass = new PersonalDocClasses();
        OutgoingBL ObjoutgoingBL = new OutgoingBL();

        #endregion

        public AddDocument()
        {
            InitializeComponent();
        }

        #region Get File Path of Document
        private void btnAddHrDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
                HRDocaPath = choofdlog.FileName;
            else
                HRDocaPath = string.Empty;
        }
        private void btnAddITDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
                ITDocaPath = choofdlog.FileName;
            else
                ITDocaPath = string.Empty;
        }
        private void btnAddFinanceDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
                FinanceDocaPath = choofdlog.FileName;
            else
                FinanceDocaPath = string.Empty;
        }
        private void btnAddPersonalDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;

            if (choofdlog.ShowDialog() == DialogResult.OK)
                PersonalDocaPath = choofdlog.FileName;
            else
                PersonalDocaPath = string.Empty;
        }

        #endregion

        #region Save Button

        //Save HR Document
        private void btnHrDocSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(textBoxDocName.Text))
                {
                    CommonModule.ShowWarningMessage("Please Fill Document Name");
                }
                else if (string.IsNullOrWhiteSpace(textBoxAbout.Text))
                {
                    CommonModule.ShowWarningMessage("Please Fill About the Document");
                }
                else
                {
                    ObjhrDocClass.HrFilePath = HRDocaPath;
                    ObjhrDocClass.HrDocumentName = textBoxDocName.Text;
                    ObjhrDocClass.AboutHrDoc = textBoxAbout.Text;
                    if (checkHR.Checked == true)
                    {
                        ObjhrDocClass.HrCheck = Convert.ToBoolean(1);
                    }
                    if (checkIT.Checked == true)
                    {
                        ObjhrDocClass.ItCheck = Convert.ToBoolean(1);
                    }
                    if (checkFinance.Checked == true)
                    {
                        ObjhrDocClass.FinanceCheck = Convert.ToBoolean(1);
                    }
                    ObjhrDocClass.AddedDate = DateTime.Now;
                }

                int recID = ObjoutgoingBL.InsertHrDocument(ObjhrDocClass);
                if (recID > 0)
                {
                    MessageBox.Show("Document " + textBoxDocName.Text + " Saved Successfully", "Successful");
                    CommonModule.ClearControlsOftheForm(this);
                    //GetEmployees();
                }

            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }

        #endregion

        private void btnITDocSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtITDocName.Text))
                {
                    CommonModule.ShowWarningMessage("Please Fill Document Name");
                }
                else if (string.IsNullOrWhiteSpace(txtITDocAbout.Text))
                {
                    CommonModule.ShowWarningMessage("Please Fill About the Document");
                }
                else
                {
                    ObjItDocClass.ItFilePath = ITDocaPath;
                    ObjItDocClass.ItDocumentName = txtITDocName.Text;
                    ObjItDocClass.AboutItDoc = txtITDocAbout.Text;
                    if (checkHRit.Checked == true)
                    {
                        ObjItDocClass.HrCheck = Convert.ToBoolean(1);
                    }
                    if (checkITit.Checked == true)
                    {
                        ObjItDocClass.ItCheck = Convert.ToBoolean(1);
                    }
                    if (checkFinanceit.Checked == true)
                    {
                        ObjItDocClass.FinanceCheck = Convert.ToBoolean(1);
                    }
                    ObjItDocClass.AddedDate = DateTime.Now;
                }

                int recID = ObjoutgoingBL.InsertItDocument(ObjItDocClass);
                if (recID > 0)
                {
                    MessageBox.Show("Document " + txtITDocName.Text + " Saved Successfully", "Successful");
                    CommonModule.ClearControlsOftheForm(this);
                    //GetEmployees();
                }

            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }

        private void btnFinanceDocSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtFinanceDocName.Text))
                {
                    CommonModule.ShowWarningMessage("Please Fill Document Name");
                }
                else if (string.IsNullOrWhiteSpace(txtFinanceDocAbout.Text))
                {
                    CommonModule.ShowWarningMessage("Please Fill About the Document");
                }
                else
                {
                    ObjFinanceDocClass.FinanceFilePath = FinanceDocaPath;
                    ObjFinanceDocClass.FinanceDocumentName = txtFinanceDocName.Text;
                    ObjFinanceDocClass.AboutFinanceDoc = txtFinanceDocAbout.Text;
                    if (checkHRfi.Checked == true)
                    {
                        ObjFinanceDocClass.HrCheck = Convert.ToBoolean(1);
                    }
                    if (checkITfi.Checked == true)
                    {
                        ObjFinanceDocClass.ItCheck = Convert.ToBoolean(1);
                    }
                    if (checkFinancefi.Checked == true)
                    {
                        ObjFinanceDocClass.FinanceCheck = Convert.ToBoolean(1);
                    }
                    ObjFinanceDocClass.AddedDate = DateTime.Now;
                }

                int recID = ObjoutgoingBL.InsertFinanceDocument(ObjFinanceDocClass);
                if (recID > 0)
                {
                    MessageBox.Show("Document " + txtFinanceDocName.Text + " Saved Successfully", "Successful");
                    CommonModule.ClearControlsOftheForm(this);
                    //GetEmployees();
                }

            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }

        private void btnPersonalDocSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtITPersonalName.Text))
                {
                    CommonModule.ShowWarningMessage("Please Fill Document Name");
                }
                else if (string.IsNullOrWhiteSpace(txtPersonalDocAbout.Text))
                {
                    CommonModule.ShowWarningMessage("Please Fill About the Document");
                }
                else
                {
                    ObjPersonalDocClass.PersonalFilePath = PersonalDocaPath;
                    ObjPersonalDocClass.PersonalDocumentName = txtITPersonalName.Text;
                    ObjPersonalDocClass.AboutPersonalDoc = txtPersonalDocAbout.Text;
                    ObjPersonalDocClass.AddedDate = DateTime.Now;
                }

                int recID = ObjoutgoingBL.InsertPersonalDocument(ObjPersonalDocClass);
                if (recID > 0)
                {
                    MessageBox.Show("Document " + txtITPersonalName.Text + " Saved Successfully", "Successful");
                    CommonModule.ClearControlsOftheForm(this);
                }

            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }
    }
}
