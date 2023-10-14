using Microsoft.Extensions.Primitives;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PFSAPI.Models
{
    public class Student : BaseEntity
    {
        [Key]
        public int StudentId { get; set; }
        [Display(Name ="GR NO")]
        [Required]
        public string GRNO { get; set; }

        [Display(Name = "Roll No")]
        [Required]
        public string RollNo { get; set; }
        [Display(Name = "Student Name")]
        [Required]
        public string StudentName { get; set; }
        [Display(Name = "Father Name")]
        [Required]
        public string FatherName { get; set; }
        [Display(Name = "Class")]
        [Required]

        public int ClassId { get; set; }
        [Display(Name = "DOB")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yyyy}")]
        public DateTime? DOB { get; set; }
        [Display(Name = "Gender")]
        [Required]
        public string Gender { get; set; }
        [Display(Name = "Phone1")]
        [Required]
        public string Phone1 { get; set; }
        [Display(Name = "Phone2")]
        [Required]
        public string Phone2 { get; set; }
        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }
        [Display(Name = "Admission Date")]
        [Required]
        [DisplayFormat(DataFormatString = "{0:MMM-dd-yyyy}")]
        public DateTime AdmissionDate { get; set; }
        [Display(Name = "Status")]
        [Required]
        public string Status { get; set; }
        [Display(Name = "Description")]
        public string? Description { get; set; }
        [Display(Name = "Father CNIC")]
        [Required]
        public string FatherCNIC { get; set; }
        [Display(Name = "Admission Fee")]
        public decimal? AdmissionFee { get; set; }
        [Display(Name = "Monthly Fee")]
        [Required]
        public decimal MonthlyFee { get; set; }
        [Display(Name = "Annual Charges")]
        public decimal? AnnualCharges { get; set; }
        [Display(Name = "Stationary Charges")]
        public decimal? StationaryCharges { get; set; }
        public virtual Class Class { get; set; }
        public ICollection<Voucher> Voucher { get; set; }
    }
    public class Status
    {
        public string Value { get; set; }
        public string Text { get; set; }
    }
}
