using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace InvestmentTrackerAPI.Models
{
    public class Stock
    {
        [Key]
        public string TikrSymbol { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string CompanyName { get; set; }

        public int Quantity { get; set; }

        public double PurchaseUnitPrice { get; set; }

        public double PurchaseCost { get; set; }

        public double SoldCost { get; set; }

        public double SoldUnitPrice { get; set; }

        public double MarketValue { get; set; }

        public DateTime PurchaseDate { get; set; }

        public DateTime SoldDate { get; set; }
    }
}
