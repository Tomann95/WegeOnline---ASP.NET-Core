using Microsoft.AspNetCore.Identity;

namespace WegeOnline.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ICollection<Order>? Orders { get; set; }
    }
}
