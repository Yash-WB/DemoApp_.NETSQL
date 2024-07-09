using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoApp.Model
{
    [Table("Customers")]
    [Index(nameof(EmailAddress), IsUnique = true)]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Customer Name is required")]
        [MaxLength(1000)]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Email Address is required")]
        [MaxLength(1000)]
        public string EmailAddress { get; set; }
        public bool IsActive { get; set; } = false;

        [MaxLength(50)]
        public string ContactNo { get; set; }
    }
}
