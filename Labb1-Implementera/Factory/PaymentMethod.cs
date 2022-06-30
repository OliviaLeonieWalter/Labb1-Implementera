using Labb1_Implementera.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb1_Implementera.Factory
{
    public interface PaymentMethod
    {
        //Factory
        string GetPaymentType();
        string PaymentMessage(Employee employee);
    }
}
