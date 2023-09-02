using System;
using System.ComponentModel.DataAnnotations;

namespace HRApp.Models
{
    public class Employee
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage ="Please Enter Name")]
        [StringLength(20, MinimumLength =3, ErrorMessage ="Invalid Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Enter Job Ttitle")]
        public string JobTtitle { get; set; }
        public string Department { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public bool IsActive { get; set; }

    }
}
