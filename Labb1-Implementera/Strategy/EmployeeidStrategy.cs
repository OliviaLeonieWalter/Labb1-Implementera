using Labb1_Implementera.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Strategy
{
    internal class EmployeeidStrategy : ISearch
    {
        //Strategy
        public void Search(string searchword, string[,] employeeArray)
        {
            var Array = employeeArray;
            string Id = null;
            string Name = null;
            string Salary = null;

            for (int i = 0; i < employeeArray.GetLength(0); i++)
            {
                if (employeeArray[i, 0] == searchword)
                {
                    Id = Array[i, 0];
                    Name = Array[i, 1];
                    Salary = Array[i, 2];

                    var SalaryEmployee = new Employee(Convert.ToInt32(Id), Name, Convert.ToDecimal(Salary));
                    Console.WriteLine($"Employee ID = {Id} \nEmployee name = {Name} \nEmployee Salary = {Salary}");
                    Console.ReadLine();
                }


            }
            if(Name == null)
            {
                Console.WriteLine("Nothing Found!");
                Console.ReadLine();
            }
        }
    }
}
