using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BugTracker.Models;

namespace BugTracker.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public Project Project { get; set; }
        public IList<ApplicationUser> Users { get; set; }
    }
}