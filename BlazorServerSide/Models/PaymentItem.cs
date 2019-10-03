using System;
using System.Collections.Generic;

namespace BlazorServerSide.Models
{
    public partial class PaymentItem
    {
        public int PaymentItemId { get; set; }
        public int PaymentId { get; set; }
        public int InvoiceId { get; set; }
        public decimal PaymentItemAmount { get; set; }

        public virtual Invoice Invoice { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
