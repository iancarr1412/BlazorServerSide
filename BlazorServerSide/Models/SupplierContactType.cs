using System;
using System.Collections.Generic;

namespace BlazorServerSide.Models
{
    public partial class SupplierContactType
    {
        public SupplierContactType()
        {
            SupplierContact = new HashSet<SupplierContact>();
        }

        public int SupplierContactTypeId { get; set; }
        public string SupplierContactTypeText { get; set; }

        public virtual ICollection<SupplierContact> SupplierContact { get; set; }
    }
}
