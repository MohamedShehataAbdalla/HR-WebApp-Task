using System.Collections.Generic;

namespace HRAppExample.Models
{
    // Seed Data Class
    public static class Repository
    {
        // Method to load data for Department
        public static List<Department> LoadDepartments() => new()
        {
            new Department { Id = 1, Name = "IT" },
            new Department { Id = 2, Name = "Finance" },
            new Department { Id = 3, Name = "Accounting" },
            new Department { Id = 4, Name = "HR" },
            new Department { Id = 5, Name = "Sales" },
        };

        // Method to load data for Employees
        public static List<Employee> LoadEmployees() => new()
        {
            new Employee
                {
                    Id = 1001,
                    FirstName = "Cochran",
                    LastName = "Cole",
                    Email = "Cole.Cochran@example.com",
                    Salary = 21000.00m,
                    IdCard = "2010-FI-1234",
                    NationalId="12345678912345",
                    JobTtitle = "Adminstrator",
                    Gender = "male",
                    DepartmentId = 2,
                    HasHealthInsurance = true,
                    HasPensionPlan = false,
                    HireDate = new DateTime(2010, 2, 1),
                    BirthDate = new DateOnly(1997, 2, 1),
                    ImageUser = "User-1001.png",
                    Skills = "ASP.NET, CSS, Oracle"
                    //Skills = new() {"ASP.NET" , "CSS" , "Oracle"}

                },
                new Employee
                {
                        Id = 1002,
                        FirstName = "Jaclyn",
                        LastName = "Wolfe",
                        Email = "Wolfe.Jaclyn@example.com",
                        Salary = 25000.00m,
                        IdCard = "2011-IT-4563",
                        NationalId="12345678998765",
                        JobTtitle = "Web Developer",
                        Gender = "male",
                        DepartmentId = 1,
                        HasHealthInsurance = true,
                        HasPensionPlan = false,
                        BirthDate = new DateOnly(1994, 2, 1),
                        HireDate = new DateTime(2011, 2, 1),
                        ImageUser = "User-1002.png",
                        Skills = "ASP.NET, SQL Server, Javascript, CSS, HTML"
                        //Skills = new() {"ASP.NET" , "SQL Server" , "Javascript" , "CSS" , "HTML"}
                },
                new Employee
                {
                        Id = 1003,
                        FirstName = "Warner",
                        LastName = "Jones",
                        Email = "Jones.Warner@example.com",
                        Salary = 23000.00m,
                        IdCard = "2012-HR-7896",
                        NationalId="12345678936985",
                        JobTtitle = "Markting",
                        Gender = "male",
                        DepartmentId = 3,
                        HasHealthInsurance = true,
                        HasPensionPlan = true,
                        HireDate = new DateTime(2012, 2, 1),
                        BirthDate = new DateOnly(1995, 2, 1),
                        ImageUser = "User-1003.png",
                        Skills = "HTML, Oracle, SQL Server"
                        //Skills = new() {"HTML" , "Oracle" , "SQL Server"}
                },
        };
    }
}
