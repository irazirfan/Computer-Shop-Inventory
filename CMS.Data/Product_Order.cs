//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMS.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Product_Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product_Order()
        {
            this.Purchase_Entry = new HashSet<Purchase_Entry>();
        }
    
        public int PONo { get; set; }
        public string PODate { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public string PName { get; set; }
        public Nullable<int> Quabtity { get; set; }
        public Nullable<double> PPU { get; set; }
        public Nullable<int> Discount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase_Entry> Purchase_Entry { get; set; }
    }
}
