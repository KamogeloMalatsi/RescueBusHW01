using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KamogeloRescueBus.Models
{
    public class Booking
    {
        public Guid BookingID { get; set; }
        public string BServiceID { get; set; }
        public int BookingType { get; set; }
        public string BFullname { get; set; }
        public string BPhone { get; set; }
        public DateTime BDate { get; set; }
        public string BPickUpTime { get; set; }
        public string BReason { get; set; }
        public int BVehicleID { get; set; }
        public int BDriverID { get; set;}
        public string pickupAddress { get; set; }
    }
}