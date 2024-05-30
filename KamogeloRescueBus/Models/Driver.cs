using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KamogeloRescueBus.Models
{
    public class Driver
    {
        public int DriverID { get; set; }
        public string DriverImage { get; set; }
        public string DriverFName { get; set; }
        public string DriverLName { get; set; }
        public string DriverPNumber { get; set; }
        public string ServiceID { get; set; }
    }
}