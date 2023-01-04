using System;
using System.ComponentModel.DataAnnotations;

namespace NguyenThuyDung124.Models
{
    public class NTD0124
    {
        [Key]
        [MaxLength(20)]
        public string? NTDId { get; set; }
        [MaxLength(50)]
        public string? NTDName { get; set; }
        public Boolean NTDGender { get; set; }
    }
}