using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GrearGo.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Customer name is required.")]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        [StringLength(150)]
        public string Email { get; set; } = string.Empty;

        [Phone]
        [StringLength(20)]
        public string? PhoneNumber { get; set; }

        // One customer can make many rental requests.
        public ICollection<RentalRequest> RentalRequests { get; set; }
            = new List<RentalRequest>();
    }
}
