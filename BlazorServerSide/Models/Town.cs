using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorServerSide.Models
{
    [Table("Town")]
    public partial class Town
    {        
        public Town()
        {
            Supplier = new HashSet<Supplier>();
        }

        public int TownId { get; set; }
        public int? CountyId { get; set; }
        public int? CountryId { get; set; }
        [Display(Name = "Town")]
        public string TownName { get; set; }
        public string TownDescripton { get; set; }

        public virtual ICollection<Supplier> Supplier { get; set; }
    }
}
