using BusinessLogicLayer;
using ERP_System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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

        HrDocClass objhr;

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

        #region Refresh All DatagridViews

        private void RefreashAll()
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
        #region Open & Delete HR Documents
        private void dgvHRdocuments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHRdocuments.CurrentCell.OwningColumn.Name == clmHrOpen.Name)
            {
                try
                {
                    //Find Cell ID
                    int hrID = Convert.ToInt32(dgvHRdocuments.Rows[e.RowIndex].Cells[clmHrDocID.Name].Value);
                    HrDocClass obj = lstHrDocuments.Find(x => x.HRDocID == hrID);
                    try
                    {
                        if (obj.HrFilePath != null)
                        {
                            Process.Start("explorer.exe", obj.HrFilePath);
                        }
                    }
                    catch (Exception ex)
                    {
                        CommonModule.ShowErrorMessage(ex);
                    }
                    // Creating a temporary file
                    string path = obj.HrFilePath;
                    // Opening the stream and reading it back.
                    using (FileStream fs = File.Open(path, FileMode.Open))
                    {
                        byte[] b = new byte[1024];
                        UTF8Encoding temp = new UTF8Encoding(true);

                        while (fs.Read(b, 0, b.Length) > 0)
                        {
                            Console.WriteLine(temp.GetString(b));
                        }
                    }
                }
                catch (Exception ex)
                {
                    CommonModule.ShowErrorMessage(ex);
                }
            }
            
            if (dgvHRdocuments.CurrentCell.OwningColumn.Name == clmHrDelete.Name)
            {
                try
                {
                    //Find Cell ID
                    int hrID = Convert.ToInt32(dgvHRdocuments.Rows[e.RowIndex].Cells[clmHrDocID.Name].Value);
                    if(hrID > 0 && hrID < 250)
                    {
                        ObjoutgoingBL = new OutgoingBL();
                        bool result = ObjoutgoingBL.DeleteHRdocuments(hrID);
                        if (result)
                        {
                            CommonModule.ShowSucessMessage( "Document Deleted Successfully");
                            
                        }
                        //CommonModule.ShowWarningMessage("This Document Has added by HR Department and Only The HR Department have the access to delete this Document");
                    }
                    if (hrID > 250 && hrID < 500)
                    {
                        //ObjoutgoingBL = new OutgoingBL();
                        //bool result = ObjoutgoingBL.DeleteITdocuments(hrID);
                        //if (result)
                        //{
                        //    CommonModule.ShowSucessMessage("Document Deleted Successfully");

                        //}
                        CommonModule.ShowWarningMessage("This Document Has added by IT Department and Only The IT Department have the access to delete this Document");

                    }
                    if (hrID > 500 && hrID < 750)
                    {
                        //ObjoutgoingBL = new OutgoingBL();
                        //bool result = ObjoutgoingBL.DeleteFinancedocuments(hrID);
                        //if (result)
                        //{
                        //    CommonModule.ShowSucessMessage("Document Deleted Successfully");

                        //}
                        CommonModule.ShowWarningMessage("This Document Has added by Finance Department and Only The Finance Department have the access to delete this Document");

                    }
                    if (hrID > 750 && hrID < 1000)
                    {
                        //ObjoutgoingBL = new OutgoingBL();
                        //bool result = ObjoutgoingBL.DeleteHRdocuments(hrID);
                        //if (result)
                        //{
                        //    CommonModule.ShowSucessMessage("Document Deleted Successfully");

                        //}
                        CommonModule.ShowWarningMessage("This Document is a personal Document.Only the person who added the document,has the the access to delete this Document");

                    }
                    RefreashAll();


                }
                catch (Exception)
                {

                    throw;
                }
               
            }

        }
        #endregion

        #region Open & Delete IT Documents
        
        private void dgvITdocuments_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvITdocuments.CurrentCell.OwningColumn.Name == clmItOpen.Name)
            {
                try
                {
                    //Find Cell ID
                    int ID = Convert.ToInt32(dgvITdocuments.Rows[e.RowIndex].Cells[clmItDocID.Name].Value);
                    ItDocClasses obj = lstItDocuments.Find(x => x.ITDocID == ID);
                    try
                    {
                        if (obj.ItFilePath != null)
                        {
                            Process.Start("explorer.exe", obj.ItFilePath);
                        }
                    }
                    catch (Exception ex)
                    {
                        CommonModule.ShowErrorMessage(ex);
                    }
                    // Creating a temporary file
                    string path = obj.ItFilePath;
                    // Opening the stream and reading it back.
                    using (FileStream fs = File.Open(path, FileMode.Open))
                    {
                        byte[] b = new byte[1024];
                        UTF8Encoding temp = new UTF8Encoding(true);

                        while (fs.Read(b, 0, b.Length) > 0)
                        {
                            Console.WriteLine(temp.GetString(b));
                        }
                    }
                }
                catch (Exception ex)
                {
                    CommonModule.ShowErrorMessage(ex);
                }
            }

            if (dgvITdocuments.CurrentCell.OwningColumn.Name == clmItDelete.Name)
            {
                try
                {
                    //Find Cell ID
                    int itID = Convert.ToInt32(dgvITdocuments.Rows[e.RowIndex].Cells[clmItDocID.Name].Value);
                    if (itID > 0 && itID < 250)
                    {
                        //ObjoutgoingBL = new OutgoingBL();
                        //bool result = ObjoutgoingBL.DeleteHRdocuments(itID);
                        //if (result)
                        //{
                        //    CommonModule.ShowSucessMessage("Document Deleted Successfully");

                        //}
                        CommonModule.ShowWarningMessage("This Document Has added by HR Department and Only The HR Department have the access to delete this Document");
                    }
                    if (itID > 250 && itID < 500)
                    {
                        ObjoutgoingBL = new OutgoingBL();
                        bool result = ObjoutgoingBL.DeleteITdocuments(itID);
                        if (result)
                        {
                            CommonModule.ShowSucessMessage("Document Deleted Successfully");

                        }
                        //CommonModule.ShowWarningMessage("This Document Has added by IT Department and Only The IT Department have the access to delete this Document");

                    }
                    if (itID > 500 && itID < 750)
                    {
                        //ObjoutgoingBL = new OutgoingBL();
                        //bool result = ObjoutgoingBL.DeleteFinancedocuments(itID);
                        //if (result)
                        //{
                        //    CommonModule.ShowSucessMessage("Document Deleted Successfully");

                        //}
                        CommonModule.ShowWarningMessage("This Document Has added by Finance Department and Only The Finance Department have the access to delete this Document");

                    }
                    if (itID > 750 && itID < 1000)
                    {
                        //ObjoutgoingBL = new OutgoingBL();
                        //bool result = ObjoutgoingBL.DeleteHRdocuments(itID);
                        //if (result)
                        //{
                        //    CommonModule.ShowSucessMessage("Document Deleted Successfully");

                        //}
                        CommonModule.ShowWarningMessage("This Document is a personal Document.Only the person who added the document,has the the access to delete this Document");

                    }
                    RefreashAll();

                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
        #endregion

        #region Open & Delete Personal Documents
        private void dgvPersondocuments_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvPersondocuments.CurrentCell.OwningColumn.Name == clmPersonalOpen.Name)
            {
                try
                {
                    //Find Cell ID
                    int ID = Convert.ToInt32(dgvPersondocuments.Rows[e.RowIndex].Cells[clmPersonalDocID.Name].Value);
                    PersonalDocClasses obj = lstPersonalDocuments.Find(x => x.PersonalDocID == ID);
                    try
                    {
                        if (obj.PersonalFilePath != null)
                        {
                            Process.Start("explorer.exe", obj.PersonalFilePath);
                        }
                    }
                    catch (Exception ex)
                    {
                        CommonModule.ShowErrorMessage(ex);
                    }
                    // Creating a temporary file
                    string path = obj.PersonalFilePath;
                    // Opening the stream and reading it back.
                    using (FileStream fs = File.Open(path, FileMode.Open))
                    {
                        byte[] b = new byte[1024];
                        UTF8Encoding temp = new UTF8Encoding(true);

                        while (fs.Read(b, 0, b.Length) > 0)
                        {
                            Console.WriteLine(temp.GetString(b));
                        }
                    }
                }
                catch (Exception ex)
                {
                    CommonModule.ShowErrorMessage(ex);
                }
            }

            if (dgvPersondocuments.CurrentCell.OwningColumn.Name == clmPersonalDelete.Name)
            {
                try
                {
                    //Find Cell ID
                    int personalID = Convert.ToInt32(dgvPersondocuments.Rows[e.RowIndex].Cells[clmPersonalDocID.Name].Value);
                    if (personalID > 0 && personalID < 250)
                    {
                        //ObjoutgoingBL = new OutgoingBL();
                        //bool result = ObjoutgoingBL.DeleteHRdocuments(personalID);
                        //if (result)
                        //{
                        //    CommonModule.ShowSucessMessage("Document Deleted Successfully");

                        //}
                        CommonModule.ShowWarningMessage("This Document Has added by HR Department and Only The HR Department have the access to delete this Document");
                    }
                    if (personalID > 250 && personalID < 500)
                    {
                        //ObjoutgoingBL = new OutgoingBL();
                        //bool result = ObjoutgoingBL.DeleteITdocuments(personalID);
                        //if (result)
                        //{
                        //    CommonModule.ShowSucessMessage("Document Deleted Successfully");

                        //}
                        CommonModule.ShowWarningMessage("This Document Has added by IT Department and Only The IT Department have the access to delete this Document");

                    }
                    if (personalID > 500 && personalID < 750)
                    {
                        //ObjoutgoingBL = new OutgoingBL();
                        //bool result = ObjoutgoingBL.DeleteFinancedocuments(personalID);
                        //if (result)
                        //{
                        //    CommonModule.ShowSucessMessage("Document Deleted Successfully");

                        //}
                        CommonModule.ShowWarningMessage("This Document Has added by Finance Department and Only The Finance Department have the access to delete this Document");

                    }
                    if (personalID > 750 && personalID < 1000)
                    {
                        ObjoutgoingBL = new OutgoingBL();
                        bool result = ObjoutgoingBL.DeletePersonaldocuments(personalID);
                        if (result)
                        {
                            CommonModule.ShowSucessMessage("Document Deleted Successfully");

                        }
                        //CommonModule.ShowWarningMessage("This Document is a personal Document.Only the person who added the document,has the the access to delete this Document");

                    }
                    RefreashAll();

                }
                catch (Exception)
                {

                    throw;
                }

            }

        }

        #endregion

        #region Open & Delete Finance Documents
        private void dgvFIdocuments_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dgvFIdocuments.CurrentCell.OwningColumn.Name == clmFiOpen.Name)
            {
                try
                {
                    //Find Cell ID
                    int ID = Convert.ToInt32(dgvFIdocuments.Rows[e.RowIndex].Cells[clmFinanceDocID.Name].Value);
                    FinanceDocClasses obj = lstFinanceDocuments.Find(x => x.FinanceDocID == ID);
                    try
                    {
                        if (obj.FinanceFilePath != null)
                        {
                            Process.Start("explorer.exe", obj.FinanceFilePath);
                        }
                    }
                    catch (Exception ex)
                    {
                        CommonModule.ShowErrorMessage(ex);
                    }
                    // Creating a temporary file
                    string path = obj.FinanceFilePath;
                    // Opening the stream and reading it back.
                    using (FileStream fs = File.Open(path, FileMode.Open))
                    {
                        byte[] b = new byte[1024];
                        UTF8Encoding temp = new UTF8Encoding(true);

                        while (fs.Read(b, 0, b.Length) > 0)
                        {
                            Console.WriteLine(temp.GetString(b));
                        }
                    }
                }
                catch (Exception ex)
                {
                    CommonModule.ShowErrorMessage(ex);
                }

            }

            if (dgvFIdocuments.CurrentCell.OwningColumn.Name == clmFiDelete.Name)
            {
                try
                {
                    //Find Cell ID
                    int personalID = Convert.ToInt32(dgvFIdocuments.Rows[e.RowIndex].Cells[clmFinanceDocID.Name].Value);
                    if (personalID > 0 && personalID < 250)
                    {
                        //ObjoutgoingBL = new OutgoingBL();
                        //bool result = ObjoutgoingBL.DeleteHRdocuments(personalID);
                        //if (result)
                        //{
                        //    CommonModule.ShowSucessMessage("Document Deleted Successfully");

                        //}
                        CommonModule.ShowWarningMessage("This Document Has added by HR Department and Only The HR Department have the access to delete this Document");
                    }
                    if (personalID > 250 && personalID < 500)
                    {
                        //ObjoutgoingBL = new OutgoingBL();
                        //bool result = ObjoutgoingBL.DeleteITdocuments(personalID);
                        //if (result)
                        //{
                        //    CommonModule.ShowSucessMessage("Document Deleted Successfully");

                        //}
                        CommonModule.ShowWarningMessage("This Document Has added by IT Department and Only The IT Department have the access to delete this Document");

                    }
                    if (personalID > 500 && personalID < 750)
                    {
                        ObjoutgoingBL = new OutgoingBL();
                        bool result = ObjoutgoingBL.DeleteFinancedocuments(personalID);
                        if (result)
                        {
                            CommonModule.ShowSucessMessage("Document Deleted Successfully");

                        }
                        // CommonModule.ShowWarningMessage("This Document Has added by Finance Department and Only The Finance Department have the access to delete this Document");

                    }
                    if (personalID > 750 && personalID < 1000)
                    {
                        //ObjoutgoingBL = new OutgoingBL();
                        //bool result = ObjoutgoingBL.DeletePersonaldocuments(personalID);
                        //if (result)
                        //{
                        //    CommonModule.ShowSucessMessage("Document Deleted Successfully");

                        //}
                        CommonModule.ShowWarningMessage("This Document is a personal Document.Only the person who added the document,has the the access to delete this Document");

                    }
                    RefreashAll();

                }
                catch (Exception)
                {

                    throw;
                }

            }


        }


        #endregion
    }
}
