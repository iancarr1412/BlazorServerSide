using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerSide.Models
{
    [Table("SupplierContact")]
    public partial class SupplierContact
    {
        public int SupplierContactId { get; set; }
        public int SupplierId { get; set; }
        public int SupplierContactTypeId { get; set; }
        public string SupplierContactFirstName { get; set; }
        public string SupplierContactLastName { get; set; }
        public string SupplierContactMobile { get; set; }
        public string SupplierContactEmail { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual SupplierContactType SupplierContactType { get; set; }
    }
}
