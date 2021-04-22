using BlazorApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services
{
    public class EmployeeService
    {
        private static List<Employee> employees = new List<Employee>();
        public EmployeeService()
        { 
        }
        public IEnumerable<Employee> GetEmployees()
        {
            return employees.AsEnumerable();
        }
        public void Add(Employee employee)
        {
            employees.Add(employee);
        }
    }
}
