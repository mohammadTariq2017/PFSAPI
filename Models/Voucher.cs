using System;
using System.ComponentModel.DataAnnotations;

namespace PFSAPI.Models
{
    public class Voucher :BaseEntity
    {
        [Key]
        public int VoucherId { get; set; }
        [Display(Name = "Student")]
        [Required]
        public int StudentId { get; set; }
        [Display(Name = "Class")]
        [Required]
        public int ClassId { get; set; }
        [Display(Name = "Title")]
        [Required]
        public string Title { get; set; }
        [Display(Name = "Month")]
        [Required]
        public string Month { get; set; }
        [Display(Name = "Due Date")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yyyy}")]
        public DateTime DueDate { get; set; }
        [Display(Name = "Receiving Date")]
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yyyy}")]
        public DateTime? ReceivingDate { get; set; }
        [Display(Name = "Amount")]
        [Required]
        public decimal Amount { get; set; }
        [Display(Name = "Discount")]
        public decimal? Discount { get; set; }
        [Display(Name = "Remaining Amount")]
        public decimal? RemainingAmount { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        public virtual Student Student { get; set; }
        public virtual Class Class { get; set; }

    }
}
