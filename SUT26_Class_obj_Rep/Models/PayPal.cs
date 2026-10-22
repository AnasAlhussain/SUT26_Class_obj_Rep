using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_obj_Rep.Models
{
    internal class PayPal : IPaymentMethod
    {
        public string PaymentMethodName { get; private set; }


        public PayPal()
        {
            PaymentMethodName = "PayPal";
        }

        public void ProsccessPayment(decimal amount)
        {
            Console.WriteLine($"Processing payment of {amount:c} using {PaymentMethodName}");
        }
    }
}
