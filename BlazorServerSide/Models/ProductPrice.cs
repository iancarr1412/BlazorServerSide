using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerSide.Models
{
    [Table("ProductPrice")]
    public partial class ProductPrice
    {
        public int ProductPriceId { get; set; }
        public int ProductId { get; set; }
        public decimal ListPrice { get; set; }
        public DateTime DateEffective { get; set; }
        public decimal VatRate { get; set; }

        public virtual Product Product { get; set; }
    }
}
