using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerSide.Models
    
{
    [Table("Invoice")]
    public partial class Invoice
    {
        public Invoice()
        {
            PaymentItem = new HashSet<PaymentItem>();
        }

        public int InvoiceId { get; set; }
        [Display(Name = "Supplier")]
        public int SupplierId { get; set; }
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime InvoiceDate { get; set; }
        [Display(Name = "PO No")]
        public int PurchaseOrderId { get; set; }
        [Display(Name = "Invoice No")]
        public string InvoiceNo { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "Total")]
        public decimal InvoiceTotalAmount { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        [Display(Name = "VAT")]
        public decimal InvoiceVatamount { get; set; }
        [Display(Name = "Description")]
        public string InvoiceDescription { get; set; }
        [Display(Name = "Comments")]
        public string InvoiceComments { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<PaymentItem> PaymentItem { get; set; }
    }
}
