﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BugTracker.Models
{
    namespace BugTracker.Models
    {
        public class TicketAttachment
        {
            public int Id { get; set; }
            public int TicketId { get; set; }
            public string FilePath { get; set; }
            public string Description { get; set; }
            [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy hh:mm tt}")]
            public System.DateTimeOffset Created { get; set; }
            public string UserId { get; set; }
            public string FileUrl { get; set; }

            // prop for ticket
            public virtual Ticket Ticket { get; set; }
            public virtual ApplicationUser User { get; set; }
        }
    }

}