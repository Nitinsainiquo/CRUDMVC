using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillRiembursement.DAL.Entities
{
    public class BillRiembursementModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Your Name")]
        public string? FullName { get; set; }
        [Required]
        [RegularExpression("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$")]
        public string? EmailId { get; set; }
        [Required]
        [Range(1000000000, 9999999999, ErrorMessage = "Please enter 10 digits")]
        public long ContactNo { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [Required]
        public string? RiembursementType { get; set; }
        [Required]
        public int RiembursementAmount { get; set; }
        [Required]
        public string? PaymentMethod { get; set; }
    }
}
