//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ShoesStoreManagement.DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetailedSho
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DetailedSho()
        {
            this.DetailedBills = new HashSet<DetailedBill>();
        }
    
        public string detailedShoesId { get; set; }
        public string shoesId { get; set; }
        public string shoesColor { get; set; }
        public Nullable<double> shoesSize { get; set; }
        public Nullable<int> shoesQuantity { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DetailedBill> DetailedBills { get; set; }
        public virtual Sho Sho { get; set; }
    }
}
