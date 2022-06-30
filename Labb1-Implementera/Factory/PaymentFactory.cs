using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Factory
{
    public abstract class PaymentFactory
    {
        //Factory
        protected abstract PaymentMethod MakePaymentMethod();

        public PaymentMethod CreatePayment()
        {
            return this.MakePaymentMethod();
        }
    }
}
