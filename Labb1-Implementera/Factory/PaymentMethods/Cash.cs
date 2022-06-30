using Labb1_Implementera.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Factory.PaymentMethods
{
    public class Cash : PaymentMethod
    {
        public string GetPaymentType()
        {
            return "Cash";
        }
        public string PaymentMessage(Employee employee)
        {
            return $"The Maschine gives you {employee.EmployeeSalary} in cash.";
        }
    }
}
