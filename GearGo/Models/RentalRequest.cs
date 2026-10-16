using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GrearGo.Models
{
    public class RentalRequest : IValidatableObject
    {
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        [Required]
        public int EquipmentId { get; set; }

        [Required(ErrorMessage = "Start date is required.")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "End date is required.")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "Pending";

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Navigation properties
        public Customer? Customer { get; set; }

        public Equipment? Equipment { get; set; }

        // Validate the rental date range.
        public IEnumerable<ValidationResult> Validate(
            ValidationContext validationContext)
        {
            if (StartDate != default &&
                EndDate != default &&
                EndDate.Date < StartDate.Date)
            {
                yield return new ValidationResult(
                    "End date cannot be earlier than start date.",
                    new[] { nameof(EndDate) });
            }
        }
    }
}
