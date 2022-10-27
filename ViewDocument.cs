using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelerClasses.OutgoingClasses;
using TravelerDetailsManagementSystem.Common;

namespace TravelerDetailsManagementSystem
{
    public partial class ViewDocument : Form
    {
        public ViewDocument()
        {
            InitializeComponent();
            dgvHRdocuments.AutoGenerateColumns = false;
        }

        #region Private Variables

        HrDocClass hrClass = new HrDocClass();
        ItDocClasses itClass = new ItDocClasses();
        FinanceDocClasses financeClass = new FinanceDocClasses();
        PersonalDocClasses personalClass = new PersonalDocClasses();

        OutgoingBL ObjoutgoingBL = new OutgoingBL();

        List<HrDocClass> lstHrDocuments;
        List<ItDocClasses> lstItDocuments;
        List<FinanceDocClasses> lstFinanceDocuments;
        List<PersonalDocClasses> lstPersonalDocuments;

        #endregion


        #region Private Methods

        #region Retrieve to HR DataGridView

        private void GetHRdocumentDetails()
        {
            ObjoutgoingBL = new OutgoingBL();
            lstHrDocuments = ObjoutgoingBL.RetrieveHRdocuments();
            dgvHRdocuments.AutoGenerateColumns = false;
            dgvHRdocuments.DataSource = lstHrDocuments;           
        }
        #endregion

        #region Retrieve to IT DataGridView

        private void GetITdocumentDetails()
        {
            ObjoutgoingBL = new OutgoingBL();
            lstItDocuments = ObjoutgoingBL.RetrieveITdocuments();
            dgvITdocuments.AutoGenerateColumns = false;
            dgvITdocuments.DataSource = lstItDocuments;
        }
        #endregion

        #region Retrieve to Finance DataGridView

        private void GetFinancedocumentDetails()
        {
            ObjoutgoingBL = new OutgoingBL();
            lstFinanceDocuments = ObjoutgoingBL.RetrieveFinancedocuments();
            dgvFIdocuments.AutoGenerateColumns = false;
            dgvFIdocuments.DataSource = lstFinanceDocuments;
        }
        #endregion

        #region Retrieve to Personal DataGridView
        private void GetPersonaldocumentDetails()
        {
            ObjoutgoingBL = new OutgoingBL();
            lstPersonalDocuments = ObjoutgoingBL.RetrievePersonaldocuments();
            dgvPersondocuments.AutoGenerateColumns = false;
            dgvPersondocuments.DataSource = lstPersonalDocuments;
        }

        #endregion

        #endregion

        private void ViewDocument_Load(object sender, EventArgs e)
        {
            try
            {
                GetHRdocumentDetails();
                GetITdocumentDetails();
                GetFinancedocumentDetails();
                GetPersonaldocumentDetails();
            }
            catch (Exception ex)
            {
                CommonModule.ShowErrorMessage(ex);
            }
        }
    }
}
