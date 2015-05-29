﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PairTradingView.Data.Entities
{
    public class Stock
    {
        [Key]
        public string Code { get; set; }

        public double Bid { get; set; }

        public double Ask { get; set; }

        public double Price { get; set; }

        public long Volume { get; set; }

        public virtual List<StockValue> History { get; set; }
    }
}