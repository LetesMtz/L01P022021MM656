using System.ComponentModel.DataAnnotations;

namespace L01P022021MM656.Models
{
    public class departamentos
    {
        [Key]
        [Display(Name = "ID")]
        public int id { get; set; }
        [Display(Name = "Departamento")]
        public string? departamento { get; set; }
    }
}
