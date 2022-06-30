using Labb1_Implementera.Factory.PaymentMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Factory.PaymentFactorys
{
    public class CashFactory : PaymentFactory
    {
        protected override PaymentMethod MakePaymentMethod()
        {
            //Factory
            PaymentMethod payment = new Cash();
            //GiveMoneyAsCash();  <--- här kommer pengarna i kontanter.
            return payment;
        }
    }
}
