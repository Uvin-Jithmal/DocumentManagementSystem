using DataAccessLayer.Common;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TravelerClasses.OutgoingClasses;
using static TravelerClasses.Enums;

namespace DataAccessLayer
{
    public class OutgoingDA
    {
        Execute objExecute;
        MySqlParameter[] param;

        #region HR Document Save

        public int InsertHrDocument(HrDocClass objhrDocClass)
        {
            int recID = 0;
            using (TransactionScope scope = new TransactionScope())
            {
                objExecute = new Execute();
                string query = "INSERT INTO hrdocuments(file_Path, document_Name, about, hr_Check, it_Check, finance_Check, added_Date, updated_Date) " +
                    "VALUES(@file_Path, @document_Name, @about, @hr_Check, @it_Check, @finance_Check, @added_Date, @updated_Date); " +
                    "SELECT LAST_INSERT_ID() AS recID";

                param = new MySqlParameter[]
                {
                        Execute.AddParameter("@file_Path",objhrDocClass.HrFilePath),
                        Execute.AddParameter("@document_Name",objhrDocClass.HrDocumentName),
                        Execute.AddParameter("@about",objhrDocClass.AboutHrDoc),
                        Execute.AddParameter("@hr_Check",objhrDocClass.HrCheck),
                        Execute.AddParameter("@it_Check",objhrDocClass.ItCheck),
                        Execute.AddParameter("@finance_Check",objhrDocClass.FinanceCheck),
                        Execute.AddParameter("@added_Date",objhrDocClass.AddedDate),
                        Execute.AddParameter("@updated_Date",objhrDocClass.AddedDate),
                };
                DataRow dr = (DataRow)objExecute.Executes(query, ReturnType.DataRow, param, CommandType.Text);
                scope.Complete();
                if (dr != null)
                {
                    recID = Convert.ToInt32(dr["recID"]);
                }
            }
            return recID;
        }


        #endregion

        #region IT Document save
        public int InsertItDocument(ItDocClasses objItDocClass)
        {
            int recID = 0;
            using (TransactionScope scope = new TransactionScope())
            {
                objExecute = new Execute();
                string query = "INSERT INTO itdocuments(file_Path, document_Name, about, hr_Check, it_Check, finance_Check, added_Date, updated_Date) " +
                    "VALUES(@file_Path, @document_Name, @about, @hr_Check, @it_Check, @finance_Check, @added_Date, @updated_Date); " +
                    "SELECT LAST_INSERT_ID() AS recID";

                param = new MySqlParameter[]
                {
                        Execute.AddParameter("@file_Path",objItDocClass.ItFilePath),
                        Execute.AddParameter("@document_Name",objItDocClass.ItDocumentName),
                        Execute.AddParameter("@about",objItDocClass.AboutItDoc),
                        Execute.AddParameter("@hr_Check",objItDocClass.HrCheck),
                        Execute.AddParameter("@it_Check",objItDocClass.ItCheck),
                        Execute.AddParameter("@finance_Check",objItDocClass.FinanceCheck),
                        Execute.AddParameter("@added_Date",objItDocClass.AddedDate),
                        Execute.AddParameter("@updated_Date",objItDocClass.AddedDate),
                };
                DataRow dr = (DataRow)objExecute.Executes(query, ReturnType.DataRow, param, CommandType.Text);
                scope.Complete();
                if (dr != null)
                {
                    recID = Convert.ToInt32(dr["recID"]);
                }
            }
            return recID;
        }
        #endregion

        #region Finance Document save
        public int InsertFinanceDocument(FinanceDocClasses objFinanceDocClass)
        {
            int recID = 0;
            using (TransactionScope scope = new TransactionScope())
            {
                objExecute = new Execute();
                string query = "INSERT INTO financedocuments(file_Path, document_Name, about, hr_Check, it_Check, finance_Check, added_Date, updated_Date) " +
                    "VALUES(@file_Path, @document_Name, @about, @hr_Check, @it_Check, @finance_Check, @added_Date, @updated_Date); " +
                    "SELECT LAST_INSERT_ID() AS recID";

                param = new MySqlParameter[]
                {
                        Execute.AddParameter("@file_Path",objFinanceDocClass.FinanceFilePath),
                        Execute.AddParameter("@document_Name",objFinanceDocClass.FinanceDocumentName),
                        Execute.AddParameter("@about",objFinanceDocClass.AboutFinanceDoc),
                        Execute.AddParameter("@hr_Check",objFinanceDocClass.HrCheck),
                        Execute.AddParameter("@it_Check",objFinanceDocClass.ItCheck),
                        Execute.AddParameter("@finance_Check",objFinanceDocClass.FinanceCheck),
                        Execute.AddParameter("@added_Date",objFinanceDocClass.AddedDate),
                        Execute.AddParameter("@updated_Date",objFinanceDocClass.AddedDate),
                };
                DataRow dr = (DataRow)objExecute.Executes(query, ReturnType.DataRow, param, CommandType.Text);
                scope.Complete();
                if (dr != null)
                {
                    recID = Convert.ToInt32(dr["recID"]);
                }
            }
            return recID;
        }

        #endregion

        #region Personal Document save
        public int InsertPersonalDocument(PersonalDocClasses objPersonalDocClass)
        {
            int recID = 0;
            using (TransactionScope scope = new TransactionScope())
            {
                objExecute = new Execute();
                string query = "INSERT INTO personaldocuments(file_Path, document_Name, about, hr_Check, it_Check, finance_Check, added_Date, updated_Date) " +
                    "VALUES(@file_Path, @document_Name, @about, @hr_Check, @it_Check, @finance_Check, @added_Date, @updated_Date); " +
                    "SELECT LAST_INSERT_ID() AS recID";

                param = new MySqlParameter[]
                {
                        Execute.AddParameter("@file_Path",objPersonalDocClass.PersonalFilePath),
                        Execute.AddParameter("@document_Name",objPersonalDocClass.PersonalDocumentName),
                        Execute.AddParameter("@about",objPersonalDocClass.AboutPersonalDoc),
                        Execute.AddParameter("@hr_Check",objPersonalDocClass.HrCheck),
                        Execute.AddParameter("@it_Check",objPersonalDocClass.ItCheck),
                        Execute.AddParameter("@finance_Check",objPersonalDocClass.FinanceCheck),
                        Execute.AddParameter("@added_Date",objPersonalDocClass.AddedDate),
                        Execute.AddParameter("@updated_Date",objPersonalDocClass.AddedDate),
                };
                DataRow dr = (DataRow)objExecute.Executes(query, ReturnType.DataRow, param, CommandType.Text);
                scope.Complete();
                if (dr != null)
                {
                    recID = Convert.ToInt32(dr["recID"]);
                }
            }
            return recID;
        }


        #endregion


        #region Reteieve HR Documents

        public List<HrDocClass> RetrieveHRdocuments()
        {
            List<HrDocClass> lstHrDocuments = new List<HrDocClass>();
            objExecute = new Execute();
            string query = "SELECT * FROM documentdatabase.hrdocuments where hr_Check = '1' UNION " +
                            "SELECT * FROM documentdatabase.itdocuments where hr_Check = '1' union " +
                            "SELECT * FROM documentdatabase.financedocuments where hr_Check = '1' union " +
                            "SELECT * FROM documentdatabase.personaldocuments where hr_Check = '1' ";
            DataTable dt = (DataTable)objExecute.Executes(query, ReturnType.DataTable, param, CommandType.Text);

            foreach (DataRow dr in dt.Rows)
            {
                lstHrDocuments.Add(new HrDocClass
                {
                    HRDocID = Convert.ToInt32(dr["doc_ID"]),                    
                    HrFilePath = dr["file_Path"].ToString(),
                    HrDocumentName = dr["document_Name"].ToString(),
                    AboutHrDoc = dr["about"].ToString(),
                    HrCheck = Convert.ToBoolean(dr["hr_Check"]),
                    ItCheck = Convert.ToBoolean(dr["it_Check"]),
                    FinanceCheck = Convert.ToBoolean(dr["finance_Check"]),
                    AddedDate = Convert.ToDateTime(dr["added_Date"]),
                    UpdatedDate = Convert.ToDateTime(dr["updated_Date"]),
                });
            }

            //string query1 = "SELECT * FROM itdocuments where hr_Check = '1' ";
            //DataTable dt1 = (DataTable)objExecute.Executes(query1, ReturnType.DataTable, param, CommandType.Text);
            //foreach (DataRow dr in dt1.Rows)
            //{
            //    lstHrDocuments.Add(new HrDocClass
            //    {
            //        //ITDocID = Convert.ToInt32(dr["doc_ID"]),
            //        //ItFilePath = dr["file_Path"].ToString(),
            //        HrDocumentName = dr["document_Name"].ToString(),
            //        AboutHrDoc = dr["about"].ToString(),
            //        HrCheck = Convert.ToBoolean(dr["hr_Check"]),
            //        ItCheck = Convert.ToBoolean(dr["it_Check"]),
            //        FinanceCheck = Convert.ToBoolean(dr["finance_Check"]),
            //        AddedDate = Convert.ToDateTime(dr["added_Date"]),
            //        UpdatedDate = Convert.ToDateTime(dr["updated_Date"]),
            //    });
            //}

            //string query2 = "SELECT * FROM financedocuments where hr_Check = '1' ";
            //DataTable dt2 = (DataTable)objExecute.Executes(query2, ReturnType.DataTable, param, CommandType.Text);
            //foreach (DataRow dr in dt2.Rows)
            //{
            //    lstHrDocuments.Add(new HrDocClass
            //    {
            //        //ITDocID = Convert.ToInt32(dr["doc_ID"]),
            //        //ItFilePath = dr["file_Path"].ToString(),
            //        HrDocumentName = dr["document_Name"].ToString(),
            //        AboutHrDoc = dr["about"].ToString(),
            //        HrCheck = Convert.ToBoolean(dr["hr_Check"]),
            //        ItCheck = Convert.ToBoolean(dr["it_Check"]),
            //        FinanceCheck = Convert.ToBoolean(dr["finance_Check"]),
            //        AddedDate = Convert.ToDateTime(dr["added_Date"]),
            //        UpdatedDate = Convert.ToDateTime(dr["updated_Date"]),
            //    });
            //}

            //string query3 = "SELECT * FROM personaldocuments where hr_Check = '1' ";
            //DataTable dt3 = (DataTable)objExecute.Executes(query3, ReturnType.DataTable, param, CommandType.Text);
            //foreach (DataRow dr in dt3.Rows)
            //{
            //    lstHrDocuments.Add(new HrDocClass
            //    {
            //        //ITDocID = Convert.ToInt32(dr["doc_ID"]),
            //        //ItFilePath = dr["file_Path"].ToString(),
            //        HrDocumentName = dr["document_Name"].ToString(),
            //        AboutHrDoc = dr["about"].ToString(),
            //        HrCheck = Convert.ToBoolean(dr["hr_Check"]),
            //        ItCheck = Convert.ToBoolean(dr["it_Check"]),
            //        FinanceCheck = Convert.ToBoolean(dr["finance_Check"]),
            //        AddedDate = Convert.ToDateTime(dr["added_Date"]),
            //        UpdatedDate = Convert.ToDateTime(dr["updated_Date"]),
            //    });
            //}

            return lstHrDocuments;
        }

        #endregion

        #region Reteieve IT Documents

        public List<ItDocClasses> RetrieveITdocuments()
        {
            List<ItDocClasses> lstItDocuments = new List<ItDocClasses>();
            objExecute = new Execute();
            string query = "SELECT * FROM documentdatabase.hrdocuments where it_Check = '1' UNION " +
                            "SELECT * FROM documentdatabase.itdocuments where it_Check = '1' union " +
                            "SELECT * FROM documentdatabase.financedocuments where it_Check = '1' union " +
                            "SELECT * FROM documentdatabase.personaldocuments where it_Check = '1' ";
            DataTable dt = (DataTable)objExecute.Executes(query, ReturnType.DataTable, param, CommandType.Text);

            foreach (DataRow dr in dt.Rows)
            {
                lstItDocuments.Add(new ItDocClasses
                {
                    ITDocID = Convert.ToInt32(dr["doc_ID"]),
                    ItFilePath = dr["file_Path"].ToString(),
                    ItDocumentName = dr["document_Name"].ToString(),
                    AboutItDoc = dr["about"].ToString(),
                    HrCheck = Convert.ToBoolean(dr["hr_Check"]),
                    ItCheck = Convert.ToBoolean(dr["it_Check"]),
                    FinanceCheck = Convert.ToBoolean(dr["finance_Check"]),
                    AddedDate = Convert.ToDateTime(dr["added_Date"]),
                    UpdatedDate = Convert.ToDateTime(dr["updated_Date"]),
                });
            }

            return lstItDocuments;
        }

        #endregion

        #region Reteieve Finance Documents

        public List<FinanceDocClasses> RetrieveFinancedocuments()
        {
            List<FinanceDocClasses> lstFinanceDocuments = new List<FinanceDocClasses>();
            objExecute = new Execute();
            string query = "SELECT * FROM documentdatabase.hrdocuments where finance_Check = '1' UNION " +
                            "SELECT * FROM documentdatabase.itdocuments where finance_Check = '1' union " +
                            "SELECT * FROM documentdatabase.financedocuments where finance_Check = '1' union " +
                            "SELECT * FROM documentdatabase.personaldocuments where finance_Check = '1' ";
            DataTable dt = (DataTable)objExecute.Executes(query, ReturnType.DataTable, param, CommandType.Text);

            foreach (DataRow dr in dt.Rows)
            {
                lstFinanceDocuments.Add(new FinanceDocClasses
                {
                    FinanceDocID = Convert.ToInt32(dr["doc_ID"]),
                    FinanceFilePath = dr["file_Path"].ToString(),
                    FinanceDocumentName = dr["document_Name"].ToString(),
                    AboutFinanceDoc = dr["about"].ToString(),
                    HrCheck = Convert.ToBoolean(dr["hr_Check"]),
                    ItCheck = Convert.ToBoolean(dr["it_Check"]),
                    FinanceCheck = Convert.ToBoolean(dr["finance_Check"]),
                    AddedDate = Convert.ToDateTime(dr["added_Date"]),
                    UpdatedDate = Convert.ToDateTime(dr["updated_Date"]),
                });
            }

            return lstFinanceDocuments;
        }

        #endregion

        #region Reteieve Personal Documents

        public List<PersonalDocClasses> RetrievePersonaldocuments()
        {
            List<PersonalDocClasses> lstPersonalDocuments = new List<PersonalDocClasses>();
            objExecute = new Execute();
            string query = "SELECT * FROM documentdatabase.personaldocuments";
            DataTable dt = (DataTable)objExecute.Executes(query, ReturnType.DataTable, param, CommandType.Text);

            foreach (DataRow dr in dt.Rows)
            {
                lstPersonalDocuments.Add(new PersonalDocClasses
                {
                    PersonalDocID = Convert.ToInt32(dr["doc_ID"]),
                    PersonalFilePath = dr["file_Path"].ToString(),
                    PersonalDocumentName = dr["document_Name"].ToString(),
                    AboutPersonalDoc = dr["about"].ToString(),
                    HrCheck = Convert.ToBoolean(dr["hr_Check"]),
                    ItCheck = Convert.ToBoolean(dr["it_Check"]),
                    FinanceCheck = Convert.ToBoolean(dr["finance_Check"]),
                    AddedDate = Convert.ToDateTime(dr["added_Date"]),
                    UpdatedDate = Convert.ToDateTime(dr["updated_Date"]),
                });
            }

            return lstPersonalDocuments;
        } 
        #endregion

    }
}
