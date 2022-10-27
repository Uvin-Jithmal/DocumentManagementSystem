using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerClasses.OutgoingClasses
{
    public class ItDocClasses
    {
        public int ITDocID { get; set; }
        public string ItFilePath { get; set; }
        public String ItDocumentName { get; set; }
        public String AboutItDoc { get; set; }
        public Boolean HrCheck { get; set; }
        public Boolean ItCheck { get; set; }
        public Boolean FinanceCheck { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

    }
}
