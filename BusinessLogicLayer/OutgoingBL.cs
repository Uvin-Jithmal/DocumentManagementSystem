using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelerClasses.OutgoingClasses;

namespace BusinessLogicLayer
{
    public class OutgoingBL
    {

        private OutgoingDA ObjoutgoingDA;


        #region Save HR Documents
        //Save HR Documents
        public int InsertHrDocument(HrDocClass objhrDocClass)
        {
            ObjoutgoingDA = new OutgoingDA();
            return ObjoutgoingDA.InsertHrDocument(objhrDocClass);
        } 
        #endregion
    }
}
