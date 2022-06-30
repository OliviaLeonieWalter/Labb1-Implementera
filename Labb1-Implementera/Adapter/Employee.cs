using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Adapter
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public decimal EmployeeSalary { get; set; }

        public Employee(int id, string name, decimal salary)
        {
            EmployeeId = id;
            EmployeeName = name;
            EmployeeSalary = salary;
        }
    }
}
