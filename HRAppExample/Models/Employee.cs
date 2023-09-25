using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRAppExample.Models
{
    [Table("Employees", Schema ="HR")]
    public class Employee
    {
        [Key]
        [Display(Name ="ID")]
        public int? Id { get; set; }

        [Required(ErrorMessage ="Please Enter First Name")]
        [Display(Name = "First Name")]
        [Column(TypeName = "VARCHAR(20)")]
        [StringLength(20, MinimumLength =3, ErrorMessage ="Invalid Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please Enter Last Name")]
        [Display(Name = "Last Name")]
        [Column(TypeName = "VARCHAR(20)")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Invalid Name")]
        public string LastName { get; set; } = string.Empty;

        [Display(Name = "Id Card")]
        [Column(TypeName = "VARCHAR(12)")]
        [StringLength(12, MinimumLength = 12, ErrorMessage = "Invalid Id Card")]
        public string? IdCard { get; set; } = string.Empty;

        [Display(Name = "Gender")]
        [Column(TypeName = "VARCHAR(6)")]
        [StringLength(6, MinimumLength = 1, ErrorMessage = "Invalid Gender")]
        public string? Gender { get; set; } = string.Empty;

        //[Required(ErrorMessage = "Please Enter Job Ttitle")]
        [Display(Name = "Job Ttitle")]
        [Column(TypeName = "VARCHAR(100)")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Invalid Job Ttitle")]
        public string JobTtitle { get; set; } = string.Empty;

        [Display(Name = "Email Address")]
        [Column(TypeName = "VARCHAR(250)")]
        [StringLength(250, MinimumLength = 6, ErrorMessage = "Invalid Email Address")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = String.Empty;

        [Display(Name = "Birth Date")]
        [Column(TypeName = "DATE")]
        [DataType(DataType.Date)]
        public DateOnly? BirthDate { get; set; }

        [Display(Name = "Hiring Date")]
        [DisplayFormat(DataFormatString ="{0:dd-MMMM-yyyy}")]
        [Column(TypeName = "DATE")]
        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [Display(Name = "Salary")]
        [Column(TypeName = "Decimal(12,2)")]
        public Decimal Salary { get; set; }

        [Display(Name = "Is Active")]
        [Column(TypeName = "TINYINT")]
        public bool IsActive { get; set; }

        [Display(Name = "HasHealth Insurance")]
        [Column(TypeName = "TINYINT")]
        public bool HasHealthInsurance { get; set; }

        [Display(Name = "Has Pension Plan")]
        [Column(TypeName = "TINYINT")]
        public bool HasPensionPlan { get; set; }

        [Display(Name = "Skills")]
        [Column(TypeName = "VARCHAR(250)")]
        public string? Skills { get; set; }

        [Display(Name = "Image")]
        [Column(TypeName = "VARCHAR(250)")]
        [StringLength(250, MinimumLength = 6, ErrorMessage = "Invalid Image User")]
        [DataType(DataType.ImageUrl)]

        public string? ImageUser { get; set; }

        [Required]
        [Display(Name = "National ID")]
        [Column(TypeName = "VARCHAR(14)")]
        [MaxLength(14)]
        [MinLength(14)]
        public string NationalId { get; set; } = String.Empty;

        [Display(Name = "Department")]
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department? Department { get; set; }

    }
}
