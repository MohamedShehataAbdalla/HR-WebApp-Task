using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRAppExample.Models
{
    [Table("Departments", Schema ="HR")]
    public class Department
    {
        [Key]
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Department Name")]
        [Column(TypeName ="VARCHAR(100)")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Invalid Department Name")]
        public string Name { get; set; } = string.Empty;

        public ICollection<Employee> Employees { get; set; } = new List<Employee>();


    }
}
