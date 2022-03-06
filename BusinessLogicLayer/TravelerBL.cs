using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelerClasses.Customer;

namespace BusinessLogicLayer
{
    public class TravelerBL
    {
        #region Private Variables
        private TravelerDA travelerDA;

        #endregion

        #region Traveler Form Methods

        //Save Traveler Details
        public int InsertTravelerDetails(TravelerClass objTraveler)
        {
            travelerDA = new TravelerDA();
            return travelerDA.InsertTravelerDetails(objTraveler);
        }

        #endregion

    }
}
