using Labb1_Implementera.Factory.PaymentMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Factory.PaymentFactorys
{
    public class CardFactory : PaymentFactory
    {
        protected override PaymentMethod MakePaymentMethod()
        {
            //Factory
            PaymentMethod payment = new Card();
            //SendMoneyToCard();  <--- här överförs pengarna.
            return payment;
        }
    }
}
