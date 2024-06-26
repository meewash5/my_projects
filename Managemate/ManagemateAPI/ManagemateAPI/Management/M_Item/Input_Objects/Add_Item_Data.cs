﻿using ManagemateAPI.Management.M_Session.Input_Objects;

namespace ManagemateAPI.Management.M_Item.Input_Objects
{
    public class Add_Item_Data
    {
        public Session_Data session { get; set; }

        public string catalog_number { get; set; }
        public string product_name { get; set; }
        public long item_type_id_FK { get; set; }
        public double weight_kg { get; set; }
        public double count { get; set; }
        public double blocked_count { get; set; }
        public double price { get; set; }
        public double tax_pct { get; set; }
        public long item_trading_type_id_FK { get; set; }
        public long item_counting_type_id_FK { get; set; }
        public string comment { get; set; }

    }
}
