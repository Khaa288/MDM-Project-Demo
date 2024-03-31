using System.ComponentModel.DataAnnotations;

namespace MDM_API.Models
{
    public class ChuyenXe
    {
        [Key]
        public int MaChuyenXe { get; set; }
        public string TenChuyenXe { get; set; }
    }
}
