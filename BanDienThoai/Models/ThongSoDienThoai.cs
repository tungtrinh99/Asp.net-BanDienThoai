//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BanDienThoai.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ThongSoDienThoai
    {
        public string MaDienThoai { get; set; }
        public string ManHinh { get; set; }
        public string HeDieuHanh { get; set; }
        public string CameraSau { get; set; }
        public string CameraTruoc { get; set; }
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string ROM { get; set; }
        public string Pin { get; set; }
        public string Sim { get; set; }
        public Nullable<int> NamSanXuat { get; set; }
    
        public virtual DMDienThoai DMDienThoai { get; set; }
    }
}
