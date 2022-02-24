using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelerClasses.Customer
{
    public class Traveler
    {
        public int TravelerID { get; set; }
        public String TravelerName { get; set; }
        public String PhoneNumber { get; set; }
        public String Email { get; set; }
        public String Country { get; set; }
        public int TownID { get; set; }
        public String TownName { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public int NoOfMembers { get; set; }
        public int NoOfNights { get; set; }
        public int RoomTypeID { get; set; }
        public String RoomTypeName { get; set; }
        public String Purpose { get; set; }
        public String VehicleType { get; set; }
        public decimal Amount { get; set; }
        public String SpecialNotes { get; set; }

    }
}
