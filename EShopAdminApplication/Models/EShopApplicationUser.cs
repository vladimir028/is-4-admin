using System.Net.Sockets;

namespace EShopAdminApplication.Models
{
    public class EShopApplicationUser
    {
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }  
        public string UserName { get; set; }    
        //public ShoppingCart? UserCart { get; set; }
        //public virtual ICollection<Ticket>? MyProducts { get; set; }
    }
}
