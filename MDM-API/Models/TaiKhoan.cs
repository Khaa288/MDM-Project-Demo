using System.ComponentModel.DataAnnotations;

namespace MDM_API.Models
{
    public class TaiKhoan
    {
        public string HoTen { get; set; }
        public int GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string NgheNghiep { get; set; }
        public string SDT { get; set; }

        [Key]
        public string Email { get; set; } // Email as username
        public string MatKhau { get; set; }
    }
}
