using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerSide.Models
{
    [Table("PaymentMethod")]
    public partial class PaymentMethod
    {
        public PaymentMethod()
        {
            Payment = new HashSet<Payment>();
        }

        public int PaymentMethodId { get; set; }
        public string PaymentMethodText { get; set; }

        public virtual ICollection<Payment> Payment { get; set; }
    }
}
