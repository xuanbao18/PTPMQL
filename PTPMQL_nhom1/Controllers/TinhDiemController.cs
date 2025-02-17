using Microsoft.AspNetCore.Mvc;
using PTPMQL.Models;
namespace PTPMQL;

public class TinhDiemController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(TinhDiem ps)
    {
        string str0utput ="tong" + ps.DiemA + "-"+ ps.DiemB+"-"+ps.DiemC;
        ViewBag.infoPerson = str0utput;
        return View();
    }
}
