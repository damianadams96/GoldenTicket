using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GoldenTicket.Models
{
    public class User
    {
        public int ID { get; set; }

        public string email { get; set; }
        public string password { get; set; }

        [StringLength(50, ErrorMessage = "First Name can not be more than 50 Characters long")]
        public string FirstName { get; set; }


        public char MdlInit { get; set; }

        [StringLength(25, ErrorMessage = "Last Name can not be more than 25 Characters long" )]
        public string LastName { get; set; }

        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }

        public int phone { get; set; }
        public string BDay { get; set; }

        public string securityQ1 { get; set; } // Security questions for forgotten password recovery
        public string SecirutyA1 { get; set; } // answer to security question

        public string securityQ2 { get; set; } // Security questions for forgotten password recovery
        public string SecirutyA2 { get; set; } // answer to security question

        public string securityQ3 { get; set; } // Security questions for forgotten password recovery
        public string SecirutyA3 { get; set; } // answer to security question

        public Boolean Employee { get; set; }

        public Boolean Admin { get; set; }

    }
}