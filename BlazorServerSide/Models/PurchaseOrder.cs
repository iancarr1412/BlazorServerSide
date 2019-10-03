using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerSide.Models
{
    [Table("PurchaseOrder")]
    public partial class PurchaseOrder
    {
        public PurchaseOrder()
        {
            PurchaseOrderItem = new HashSet<PurchaseOrderItem>();
        }

        [Display(Name = "PO")]
        public int PurchaseOrderId { get; set; }
        public int SupplierId { get; set; }
        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PurchaseOrderDate { get; set; }
        [Display(Name = "Delivery Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? PurchaseOrderDeliveryDate { get; set; }
        [Display(Name = "Ref")]
        public string PurchaseOrderReference { get; set; }
        public string PurchaseOrderNote { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual ICollection<PurchaseOrderItem> PurchaseOrderItem { get; set; }
    }
}
