using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerSide.Models
{
    [Table("Product")]
    public partial class Product
    {
        public Product()
        {
            ProductPrice = new HashSet<ProductPrice>();
            PurchaseOrderItem = new HashSet<PurchaseOrderItem>();
        }

        public int ProductId { get; set; }
        public int SupplierId { get; set; }
        public int? ProductCategoryId { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCaseSize { get; set; }
        public string PalletQty { get; set; }
        public decimal ListPrice { get; set; }
        public DateTime? ListPriceEffectiveDate { get; set; }
        public decimal? VatRate { get; set; }
        public bool? Discontinued { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<ProductPrice> ProductPrice { get; set; }
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItem { get; set; }
    }
}
