using System;
using Microsoft.AspNetCore.Mvc;
using PTPMQL.Models;
namespace PTPMQL;

public class BMIController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(BMI model)
    {
        {
             string str0utput ="-" + model.Gender + "-"+ model.Height+"-"+model.Weight;
            ViewBag.BMIModel = str0utput;
            
        return View();
    }
}
}