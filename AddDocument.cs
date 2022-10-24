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

        HrDocClass ObjhrDocClass = new HrDocClass();
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

    }
}
