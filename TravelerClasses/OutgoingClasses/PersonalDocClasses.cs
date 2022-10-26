using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerClasses.OutgoingClasses
{
    public class PersonalDocClasses
    {
        public int PersonalDocID { get; set; }
        public string PersonalFilePath { get; set; }
        public String PersonalDocumentName { get; set; }
        public String AboutPersonalDoc { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}
