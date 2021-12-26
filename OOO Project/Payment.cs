using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOO_Project
{
    public abstract class Payment
    {
        public string Stringİnformation1 { get; set; }
        public int TotalPrice { get; set; }
        public abstract int Pay(int a ,int b);
    }
}
