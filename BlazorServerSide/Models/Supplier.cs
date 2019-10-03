using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerSide.Models
{
    [Table("Supplier")]
    public partial class Supplier
    {
        public Supplier()
        {
            Invoice = new HashSet<Invoice>();
            Product = new HashSet<Product>();
            PurchaseOrder = new HashSet<PurchaseOrder>();
            SupplierContact = new HashSet<SupplierContact>();
        }

        public int SupplierId { get; set; }
        public int TownId { get; set; }
        [Display(Name = "Supplier")]
        public string SupplierName { get; set; }
        [Display(Name = "Add 1")]
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Add3 { get; set; }
        public string Postcode { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string BankSortCode { get; set; }
        public string BankAccountNo { get; set; }

        public virtual Town Town { get; set; }
        public virtual ICollection<Invoice> Invoice { get; set; }
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<PurchaseOrder> PurchaseOrder { get; set; }
        public virtual ICollection<SupplierContact> SupplierContact { get; set; }
    }
}
