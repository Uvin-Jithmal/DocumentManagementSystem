using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerClasses.OutgoingClasses
{
    public class HrDocClass
    {
        public int HRDocID { get; set; }
        public string HrFilePath { get; set; }
        public String HrDocumentName { get; set; }
        public String AboutHrDoc { get; set; }
        public Boolean HrCheck { get; set; }
        public Boolean ItCheck { get; set; }
        public Boolean FinanceCheck { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
