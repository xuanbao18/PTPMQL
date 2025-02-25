using Microsoft.AspNetCore.Mvc;
using PTPMQL.Data;
using PTPMQL.Models;

namespace PTPMQL.Controllers
{
    public class PersonController : Controller
    {
        private readonly ApplicationDbcontext _context;
        public PersonController(ApplicationDbcontext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Person.ToListAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersonID,FullName,Address")] Person person)
        {
            if (ModelState.IsValid)
            {
                _context.Add(person);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }
        public async <IActionResult> Edit (string ID)
        {
            if (ID == null || _context.Person == null)
            {
                return NotFound();
            } 
            var person = await _context.Person.FindAsync(ID);
            if (person == null)
        }
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
}