//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VLU231_71SEOO30074_03.src
{
    using System;
    using System.Collections.Generic;
    
    public partial class TaiKhoan
    {
        public string MaNgD { get; set; }
        public string TenTk { get; set; }
        public string MatKhau { get; set; }
    
        public virtual NguoiDung NguoiDung { get; set; }
    }
}
