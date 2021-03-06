﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoldenTicket.Models
{
    public class Ticket
    {
        public int ticketID  { get; set; }

        [Display(Name = "Your Email")]
        public string customerID { get; set; }

        public string subject { get; set; }

        [DataType (DataType.MultilineText)]
        public string cutomerNotes { get; set; }

        [DataType (DataType.MultilineText)]
        public string empNotes { get; set; }

        public string date { get; set;}

        public string dataResponded { get; set; }

        public Boolean closed { get; set; }

    }
}
