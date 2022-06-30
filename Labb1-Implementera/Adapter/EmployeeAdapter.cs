using Labb1_Implementera.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Adapter
{
    internal class EmployeeAdapter : ITarget
    {
        //Adapter
        SalaryPay salaryPay = new SalaryPay();
        public void ProcessPayCheck(string[,] employeeArray, string employeeName)
        {
            var Array = employeeArray;
            string Id = null;
            string Name = null;
            string Salary = null;

            for (int i = 0; i < employeeArray.GetLength(0); i++)
            {
                if (employeeArray[i, 1].ToLower() == employeeName.ToLower())
                {
                    Id = Array[i, 0];
                    Name = Array[i, 1];
                    Salary = Array[i, 2];

                    var SalaryEmployee = new Employee(Convert.ToInt32(Id), Name, Convert.ToDecimal(Salary));
                    salaryPay.ProcessSalary(SalaryEmployee);
                }
                

            }
            if(Name == null)
            {
                Console.WriteLine("No one Found with that name!");
            }
        }
    }
}
