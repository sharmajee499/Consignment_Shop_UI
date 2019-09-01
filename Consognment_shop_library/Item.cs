﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Consognment_shop_library
{
    public class Item
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }
        public bool PaymentDistributed { get; set; }
        public VendorClass Owener { get; set; }


    }
}
