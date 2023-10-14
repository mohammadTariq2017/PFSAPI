using PFSAPI.Models;
using System.ComponentModel.DataAnnotations;

namespace PFSAPI.ViewModels 
{
    public class ClassVM
    {
        public int ClassId { get; set; }
        [Display(Name = "Session")]
        [Required(ErrorMessage ="This Field is Required")]
        public int SessionId { get; set; }
        [Display(Name = "Class Name")]
        [Required(ErrorMessage = "This Field is Required")]
        public string ClassName { get; set; }
        [Display(Name = "Description")]
        [MaxLength(500, ErrorMessage = "Maximum 500 characters")]
        public string Description { get; set; }
        public string SessionName { get; set; }
    }
}
