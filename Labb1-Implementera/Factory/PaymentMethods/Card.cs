using Labb1_Implementera.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Factory.PaymentMethods
{
    public class Card : PaymentMethod
    { 
        public string GetPaymentType()
        {
            return "Card";
        }
        public string PaymentMessage(Employee employee)
        {
            return $"Added {employee.EmployeeSalary} on your card";
        }
    }
}
