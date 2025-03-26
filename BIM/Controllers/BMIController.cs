using Microsoft.AspNetCore.Mvc;
using BIM.Models; // Thêm dòng này để tham chiếu namespace chứa class BMI

public class BMIController : Controller
{
    [HttpGet]
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Index(BMI model) // Sửa từ BIM thành BMI
    {
        // Tính chỉ số BMI
        model.ChiSoBMI = model.ChieuCao * model.ChieuCao / model.CanNang;

        // Phân loại theo WHO
        if (model.ChiSoBMI < 18.5)
            model.PhanLoai = "Thiếu cân";
        else if (model.ChiSoBMI < 25)
            model.PhanLoai = "Bình thường";
        else if (model.ChiSoBMI < 30)
            model.PhanLoai = "Thừa cân";
        else
            model.PhanLoai = "Béo phì";

        // Gửi thông báo qua ViewBag
        ViewBag.KetQua = $"Chỉ số BMI của bạn là: {model.ChiSoBMI:F1} - {model.PhanLoai}";
        
        return View(model);
    }
}