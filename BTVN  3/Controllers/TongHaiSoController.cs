using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Evaluation;

namespace BTVN__3.Controllers
{
    public class TongHaiSoController : Controller
    { 
        public IActionResult Index()
        {
            ViewData["Message"] = " ";
            return View();
        }
        [HttpPost]
        public IActionResult Index(int soNguyen1, int soNguyen2)
        {
            ViewData["SoNguyen1"] = soNguyen1;
            ViewData["SoNguyen2"] = soNguyen2;
            ViewData["KetQua"] = soNguyen1 + soNguyen2;
            return View();
        }
    }
}
