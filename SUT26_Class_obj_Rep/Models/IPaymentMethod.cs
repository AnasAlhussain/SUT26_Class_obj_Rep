using System;
using System.Collections.Generic;
using System.Text;

namespace SUT26_Class_obj_Rep.Models
{
    internal interface IPaymentMethod
    {

        void ProsccessPayment(decimal amount);


        string PaymentMethodName { get; }
    }
}
