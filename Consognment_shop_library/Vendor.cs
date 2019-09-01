using System;
using System.Collections.Generic;
using System.Text;

namespace Consognment_shop_library
{
    public class VendorClass
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public double Comission { get; set; }

        public VendorClass()
        {
            Comission = 0.5;

        }

    }
}
