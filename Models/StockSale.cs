using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Stock_App.Models
{
    public class StockSale
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName="nvarchar(100)")]
        public string StockName { get; set; }
        [Column(TypeName="nvarchar(255)")]
        public string Description { get; set; }
        [Column(TypeName="decimal(2)")]
        public decimal PurchasePrice { get; set; }
        [Column(TypeName="decimal(2)")]
        public decimal? SalePrice { get; set; }
        [Column(TypeName="nvarchar(100)")]
        public string Strategy { get; set;}
    }
}
