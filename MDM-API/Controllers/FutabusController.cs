using MDM_API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MDM_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FutabusController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> DangNhap(string email, string matKhau)
        {
            using var dbcontext = new AppDbContext();

            var taikhoan = await dbcontext.TaiKhoan.AnyAsync(tk => tk.Email == email && tk.MatKhau == matKhau);

            if (taikhoan)
            {
                return Ok(1);
            }

            return BadRequest(0);
        }

        [HttpGet]
        public async Task<IActionResult> ListChuyenXe()
        {
            using var dbcontext = new AppDbContext();

            var chuyenxe = await dbcontext.ChuyenXe.ToListAsync();

            return Ok(chuyenxe);
        }
    }
}
