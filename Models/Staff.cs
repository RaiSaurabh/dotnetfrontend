using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ASP_NET_Core_App.Models
{
    [DisplayName("Staff Information")]
    public class Staff
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        [Required]
        [DisplayName("Last Name")]
        public string? LastName { set; get; }
        [Required]
        [DisplayName("First Name")]
        public string? FirstName { set; get; }
        [Required]
        public string? Address { set; get; }
        [Required]
        public string? Designation { set; get; }
        [Required]
        [DisplayName("Staff Number")]
        public string? StaffNo { set; get; }
    }
}
