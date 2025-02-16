using Microsoft.AspNetCore.Mvc;
using PTPMQL.Models;

namespace PTPMQL;

public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Person ps)
    {
        string str0utput ="xin chao" + ps.PersonID + "-"+ ps.FullName+"-"+ps.Address;
        ViewBag.infoPerson = str0utput;
        return View();
    }
}
