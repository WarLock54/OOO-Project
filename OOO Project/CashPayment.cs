using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOO_Project
{
    public class CashPayment : Payment, PaymentScreenTYPE
    {
        public override int Pay(int a, int b)
        {
            TotalPrice = a * b;
            if (TotalPrice >= 10000)
            {
                Stringİnformation1 = "Our shoopping price for your shopping over 10.000Tland discount rate is %20";
                TotalPrice -=  (TotalPrice / 20);
                
            }
            return TotalPrice;
        }

        public string PaymentScreen()
        {
            return " Cash paid(including tax)";

        }
    }
}
