using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerSide.Models
{
    [Table("Payment")]
    public partial class Payment
    {
        public Payment()
        {
            PaymentItem = new HashSet<PaymentItem>();
        }

        public int PaymentId { get; set; }
        public int PaymentMethodId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string BankChequeRef { get; set; }
        public string PaymentNote { get; set; }

        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual ICollection<PaymentItem> PaymentItem { get; set; }
    }
}
