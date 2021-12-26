using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOO_Project
{
    public class CheckPayment : Payment, PaymentScreenTYPE
    {
        public string BankName { get; set; }
        public int CheckCode { get; set; }
        public override int Pay(int a, int b)
        {
            TotalPrice = a * b;
            if (TotalPrice >= 15000)
            {
                Stringİnformation1 = "Our shoopping price for your shopping over15.000Tl and discount rate is %5";
                TotalPrice -=   (TotalPrice / 5);

            }
            return TotalPrice;
        }

        public string PaymentScreen()
        {
            return "Paid by Check(including tax)";
        }
    }
}
