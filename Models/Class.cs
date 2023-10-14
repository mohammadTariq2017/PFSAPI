using System.ComponentModel.DataAnnotations;

namespace PFSAPI.Models
{
    public class Class : BaseEntity
    {

        [Key]
        public int ClassId { get; set; }
        [Display(Name = "Session")]
        [Required]
        public int SessionId { get; set; }
        [Display(Name = "Class Name")]
        [Required]
        public string ClassName { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }
        public Session Session { get; set; }
        public ICollection<Student> Student { get; set; }
        public ICollection<Voucher> Voucher { get; set; }
    }
}
