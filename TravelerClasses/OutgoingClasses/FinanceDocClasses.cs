using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerClasses.OutgoingClasses
{
    public class FinanceDocClasses
    {
        public int FinanceDocID { get; set; }
        public string FinanceFilePath { get; set; }
        public String FinanceDocumentName { get; set; }
        public String AboutFinanceDoc { get; set; }
        public Boolean HrCheck { get; set; }
        public Boolean ItCheck { get; set; }
        public Boolean FinanceCheck { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
