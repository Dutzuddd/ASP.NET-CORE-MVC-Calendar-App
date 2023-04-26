using Microsoft.AspNetCore.Identity;

namespace Proiect_1_test.Models
{
    public class ApplicationUsercs : IdentityUser
    {
        public virtual ICollection<Event> Events { get; set; }
    }
}
