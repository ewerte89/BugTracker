using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BugTracker.Models;

namespace BugTracker.ViewModels
{
    public class UserListViewModel
    {
        public IList<ApplicationUser> Users { get; set; }
        public Dictionary<string, string> Roles { get; set; }
    }
}