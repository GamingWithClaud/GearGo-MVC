using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GearGo.Models
{
    public class Equipment
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Equipment name is required.")]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Range(typeof(decimal), "0.01", "1000000",
            ErrorMessage = "Daily rate must be greater than zero.")]
        public decimal DailyRate { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        [StringLength(50)]
        public string Category { get; set; } = string.Empty;

        // One piece of equipment can have many rental requests.
        public ICollection<RentalRequest> RentalRequests { get; set; } = new List<RentalRequest>();

        public string Description { get; internal set; }
        public string ImageUrl { get; internal set; }
        public bool IsAvailable { get; internal set; }
    }
}