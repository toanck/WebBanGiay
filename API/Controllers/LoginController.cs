using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using AppC5API.ViewModels;
using AppData.IRepositories;
using AppData.Repositories;
using BanGiayTheThao.Models;

namespace AppC5API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {

        GiayDBcontext context;
           
        public LoginController()
        {   context= new GiayDBcontext();

        }
        [HttpPost("api/Checknd")]
         public IActionResult Checknd(LoginViewModel loginViewModel)
        {
            var user = context.NguoiDungs.Where(x => x.TenDangNhap == loginViewModel.TenDangNhap && x.MatKhau == loginViewModel.MatKhau).FirstOrDefault();
            return Ok(user);
        }
        [HttpPost("api/Checknv")]
        public IActionResult Checkcv(LoginViewModel loginViewModel)
        {
            var user = context.NguoiDungs.Where(x => x.TenDangNhap == loginViewModel.TenDangNhap && x.MatKhau == loginViewModel.MatKhau).FirstOrDefault();

            var role = context.ChucVus.Where(x => x.IdChucVu ==user.IdChucVu).FirstOrDefault();
            return Ok(role);
        }
    }
}
