//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class MusteriBireysel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MusteriBireysel()
        {
            this.BireyselUnvans = new HashSet<BireyselUnvan>();
        }
    
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TC { get; set; }
        public System.DateTime DogumTarihi { get; set; }
        public int MusteriID { get; set; }
    
        public virtual Musteri Musteri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BireyselUnvan> BireyselUnvans { get; set; }
    }
}