using Labb1_Implementera.Adapter;
using Labb1_Implementera.Factory.PaymentFactorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Models
{
    public class SalaryPay
    {
        //Adapter och Factory
        public void ProcessSalary(Employee employee)
        {
            Console.WriteLine($"Hello {employee.EmployeeName}, this month salary is {employee.EmployeeSalary}, how would you like to take the Payment? \nCash \nCard \nCreditpoints");
            string choice = Console.ReadLine().ToLower();
            switch (choice)
            {
                case "cash":
                    var cash = new CashFactory().CreatePayment();
                    Console.WriteLine($"You Choose {cash.GetPaymentType()}! \n{cash.PaymentMessage(employee)}");
                    break;
                case "card":
                    var card = new CardFactory().CreatePayment();
                    Console.WriteLine($"You Choose {card.GetPaymentType()}! \n{card.PaymentMessage(employee)}");
                    break;
                case "creditpoints":
                    var creditPoints = new CreditPointsFactory().CreatePayment();
                    Console.WriteLine($"You Choose {creditPoints.GetPaymentType()}! \n{creditPoints.PaymentMessage(employee)}");
                    break;
                default:
                    Console.WriteLine("No such payment as " + choice + " does exist, back to the menu");
                    break;
            }
            
        }
    }
}
