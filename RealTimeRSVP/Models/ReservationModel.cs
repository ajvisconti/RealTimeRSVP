using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RealTimeRSVP.Models
{
    public class ReservationModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public int Row { get; set; }
        public string Seat { get; set; }
    }
}