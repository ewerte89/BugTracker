using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class ContactMessage
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        [EmailAddress]
        public string FromEmail { get; set; }
    }
}