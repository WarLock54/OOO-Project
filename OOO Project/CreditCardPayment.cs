using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOO_Project
{
    public class CreditCardPayment : Payment, PaymentScreenTYPE
    {
        public double CardNumber { get; set; }
        public int Cvc { get; set; }
        public int year { get; set; }
        public override int Pay(int a, int b)
        {
            TotalPrice = a * b;
            if (TotalPrice > 20000)
            {
                Stringİnformation1 = "Our shoopping price for your shopping over 20.000 and discount rate is %12";
                TotalPrice -= (TotalPrice / 10);

            }
            else if (TotalPrice <= 20000&& TotalPrice >= 10000)
            {
                Stringİnformation1 = "Our shoopping price for your shopping over 20.000 and discount rate is %8";
                TotalPrice -=   (TotalPrice / 8);
            }
            return TotalPrice;
        }

        public string PaymentScreen()
        {
            return "Paid by Credit card(including tax)";
        }
    }
}
