//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mvc_Stok.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Tbl_Urunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tbl_Urunler()
        {
            this.Tbl_Satıslar = new HashSet<Tbl_Satıslar>();
        }
    
        public int UrunId { get; set; }
        public string UrunAdı { get; set; }
        public Nullable<short> UrunKategori { get; set; }
        public Nullable<decimal> UrunFiyat { get; set; }
        public string UrunMarka { get; set; }
        public Nullable<byte> Stok { get; set; }
    
        public virtual Tbl_Kategoriler Tbl_Kategoriler { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tbl_Satıslar> Tbl_Satıslar { get; set; }
    }
}
