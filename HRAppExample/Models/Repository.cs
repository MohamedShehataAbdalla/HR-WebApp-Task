using System.Collections.Generic;

namespace HRAppExample.Models
{
    public class Repository
    {
        public static List<Employee> ListEmployees= new List<Employee>();

        public static IEnumerable<Employee> GetEmployees()
        {
            return ListEmployees;
        }

        public static void AddEmployee(Employee emp)
        {
            ListEmployees.Add(emp);
        }
    }
}
