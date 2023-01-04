using System.ComponentModel.DataAnnotations;
namespace NguyenThuyDung124.Models
{
    public class CompanyNTD124
    {
        [Key]
        [MaxLength(20)]
        public string? CompanyId { get; set; }
        [MaxLength(50)]
        public string? CompanyName { get; set; }
    }
}