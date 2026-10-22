using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_obj_Rep.Models
{
    internal class CreaditCard : IPaymentMethod
    {
        public string PaymentMethodName { get; private set; }


        public CreaditCard()
        {
            PaymentMethodName = "Creadit Card";
        }

        public void ProsccessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:c} using {PaymentMethodName}");

        }
    }
}
