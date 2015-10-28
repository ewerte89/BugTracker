using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BugTracker.Models;

namespace BugTracker.ViewModels
{
    public class HomePageViewModel
    {
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<Ticket> Tickets { get; set; } 
    }
}