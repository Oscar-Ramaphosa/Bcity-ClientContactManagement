using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace Bcity_Practical.Models
{
    public class Client
    {
        // Primary Key
        public int Id { get; set; }

        // Client name (required)
        [Required]
        public string Name { get; set; }

        // Auto-generated client code (unique)
        public string? ClientCode { get; set; }

        // Navigation property for many-to-many relationship
        public ICollection<ClientContact>? ClientContacts { get; set; } // be nullable because new client has no contacts yet
    }
}
