//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NpnBaiKiemTraGK.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class npnMonHoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public npnMonHoc()
        {
            this.npnKetquas = new HashSet<npnKetqua>();
        }
    
        public string npnMaMH { get; set; }
        public string npnTenMH { get; set; }
        public string npnSotiet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<npnKetqua> npnKetquas { get; set; }
    }
}
