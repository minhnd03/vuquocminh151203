using Microsoft.AspNetCore.Mvc;
using TinhDiemMonHoc.Models;

namespace TinhDiemMonHoc.Controllers
{
    public class DiemMonHocController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TinhDiem(double diemA, double diemB, double diemC)
        {
            var diemMonHoc = new DiemMonHoc
            {
                DiemA = diemA,
                DiemB = diemB,
                DiemC = diemC
            };

            double diemTong = diemMonHoc.TinhDiemTong();
            ViewBag.DiemTong = diemTong;

            return View("KetQua");
        }
    }
}
