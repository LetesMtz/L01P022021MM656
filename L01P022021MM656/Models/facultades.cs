using System.ComponentModel.DataAnnotations;

namespace L01P022021MM656.Models
{
    public class facultades
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Facultad")]
        public string? facultad { get; set; }
    }
}
