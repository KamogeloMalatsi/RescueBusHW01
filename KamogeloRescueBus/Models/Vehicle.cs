using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KamogeloRescueBus.Models
{
    public class Vehicle
    {
        public int VehicleID { get; set; }
        public string VehicleImage { get; set; }
        public string VehicleType { get; set; }
        public string VehicleRegistration { get; set; }
        public string ServiceID { get; set; }

    }
}