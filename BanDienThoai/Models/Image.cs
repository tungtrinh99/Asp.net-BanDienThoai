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
    
    public partial class Image
    {
        public string MaDienThoai { get; set; }
        public string Anh1 { get; set; }
        public string Anh2 { get; set; }
        public string Anh3 { get; set; }
        public string Anh4 { get; set; }
    
        public virtual DMDienThoai DMDienThoai { get; set; }
    }
}
