using DataAccessLayer.Common;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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

    }
}
