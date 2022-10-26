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
        public int InsertItDocument(ItDocClasses objhrDocClass)
        {
            ObjoutgoingDA = new OutgoingDA();
            return ObjoutgoingDA.InsertItDocument(objhrDocClass);
        }
        public int InsertFinanceDocument(FinanceDocClasses objFinanceDocClass)
        {
            ObjoutgoingDA = new OutgoingDA();
            return ObjoutgoingDA.InsertFinanceDocument(objFinanceDocClass);
        }
        public int InsertPersonalDocument(PersonalDocClasses objPersonalDocClass)
        {
            ObjoutgoingDA = new OutgoingDA();
            return ObjoutgoingDA.InsertPersonalDocument(objPersonalDocClass);
        }
        #endregion
    }
}
