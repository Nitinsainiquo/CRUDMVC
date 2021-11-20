using System.ComponentModel.DataAnnotations;

namespace Demo_CRUD.Models
{
    public class BillRiembursementModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Enter Your Name")]
        public string? FullName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
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
