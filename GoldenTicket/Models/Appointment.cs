using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoldenTicket.Models
{
    public class Appointment
    {

        public int appointmentID { get; set;
        }
        public string customerEmail { get; set; }
        
        public string employeeEmail { get; set; }

        public string ticketID { get; set; }
        
        public string date { get; set; } 
    }
}