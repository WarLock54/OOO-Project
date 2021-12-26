using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOO_Project
{
    public class Item
    {
            
        public int ProductID { get; set; }

        public int ShippingWeight { get; set; }
        public string BuyProductSelect()
        {
            return("Form Customer daki Product id" + ProductID);
        }
    }
}
