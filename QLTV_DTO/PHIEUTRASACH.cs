//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTV_DTO
{
    using System;
    using System.Collections.Generic;
    
    public partial class PHIEUTRASACH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUTRASACH()
        {
            this.CTBCTKTRATREs = new HashSet<CTBCTKTRATRE>();
        }
    
        public string MaPhieuMS { get; set; }
        public string MaSach { get; set; }
        public System.DateTime NgayTra { get; set; }
        public int SoNgayMuon { get; set; }
        public decimal TienPhat { get; set; }
        public string TinhTrangTraSach { get; set; }
        public string GhiChu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTBCTKTRATRE> CTBCTKTRATREs { get; set; }
        public virtual CTPHIEUMUON CTPHIEUMUON { get; set; }
    }
}
