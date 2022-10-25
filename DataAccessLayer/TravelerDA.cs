using DataAccessLayer.Common;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using TravelerClasses.Customer;
using static TravelerClasses.Enums;

namespace DataAccessLayer
{
    public class TravelerDA
    {
        Execute objExecute;
        MySqlParameter[] param;

        #region Traveler Form Methods

        //Save Traveler Details
        public int InsertTravelerDetails(TravelerClass objTraveler)
        {
            int recID = 0;
            using (TransactionScope scope = new TransactionScope())
            {
                objExecute = new Execute();
                string query = "INSERT INTO traveler(travelerName, phoneNo, travelerEmail, country, townID, dateFrom, dateTo, numOfMembers, numOfNights, roomTypeID, vehicleType, amount, specialNotes, enteredOn) " +
                    "VALUES(@travelerName, @phoneNo, @travelerEmail, @country, @townID, @dateFrom, @dateTo, @numOfMembers, @numOfNights, @roomTypeID, @vehicleType, @amount, @specialNotes, @enteredOn); " +
                    "SELECT LAST_INSERT_ID() AS recID";

                param = new MySqlParameter[]
                {
                        Execute.AddParameter("@travelerName",objTraveler.TravelerName),
                        Execute.AddParameter("@phoneNo",objTraveler.PhoneNumber),
                        Execute.AddParameter("@travelerEmail",objTraveler.Email),
                        Execute.AddParameter("@country",objTraveler.Country),
                        Execute.AddParameter("@townID",objTraveler.TownID),
                        Execute.AddParameter("@dateFrom",objTraveler.DateFrom),
                        Execute.AddParameter("@dateTo",objTraveler.DateTo),
                        Execute.AddParameter("@numOfMembers",objTraveler.NoOfMembers),
                        Execute.AddParameter("@numOfNights",objTraveler.NoOfNights),
                        Execute.AddParameter("@roomTypeID",objTraveler.RoomTypeID),
                        Execute.AddParameter("@vehicleType",objTraveler.VehicleType),
                        Execute.AddParameter("@amount",objTraveler.Amount),
                        Execute.AddParameter("@specialNotes",objTraveler.SpecialNotes),
                        Execute.AddParameter("@enteredOn",objTraveler.EnteredOn),
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
