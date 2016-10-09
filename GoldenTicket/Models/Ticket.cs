using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoldenTicket.Models
{
    public class Ticket
    {
        public int ticketID  { get; set; }
        public string customerID { get; set; }
        public string subject { get; set; }
        public string cutomerNotes { get; set; }
        public string empNotes { get; set; }
        public string date { get; set;}
        public string dataResponded { get; set; }

    }
}
