using Labb1_Implementera.Factory.PaymentMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Factory.PaymentFactorys
{
    public class CreditPointsFactory : PaymentFactory
    {
        protected override PaymentMethod MakePaymentMethod()
        {
            //Factory
            PaymentMethod payment = new CreditPoints();
            //SendMoneyToBankCredit();  <--- här överförs pengarna till BankCredit.
            return payment;
        }
    }
}
