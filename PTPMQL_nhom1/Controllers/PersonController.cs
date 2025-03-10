using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PTPMQL.Data;
using PTPMQL.Models;


namespace PTPMQL.Controllers
{
    public class PersonController : Controller
    
    {
        private readonly ApplicationDbContext _context;
        private object await_context;

        public PersonController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var model = await _context.Persons.ToListAsync();
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
        public async Task<IActionResult> Edit (string ID)
        {
            if (ID == null || _context.Persons == null)
            {
                return NotFound();
            } 

            var person = await _context.Persons.FindAsync(ID);
            if (person == null)
            { 
                return NotFound();
            }
            return View(person);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string ID, [Bind("PersonID,FullName,Address")] Person person)
        {
            if (ID != person.PersonID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(person);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonExists(person.PersonID) )
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(person);
        }
        public async Task<IActionResult> Delete(string ID)
        {
            if (ID ==null || _context.Person == null)
            {
                return NotFound();
            }

            var person = await _context.Persons
                .FirstOrDefaultAsync(m => m.PersonID == ID);
            if (person == null)
            {
                return NotFound();
            }

            return View(person);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string ID)
        {
            if (_context.Person == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Person' is null."); 
            }
            var person = await _context.Persons.FindAsync(ID);
            if (person != null)
            {
                _context.Persons.Remove(person);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        private bool PersonExists(string ID)
        {
            return (_context.Persons?.Any(e => e.PersonID == ID)).GetValueOrDefault();
        }

     
    [HttpPost]
    public IActionResult Index(Person ps)
    
    {
        string str0utput ="xin chao" + ps.PersonID + "-"+ ps.FullName+"-"+ps.Address;
        ViewBag.infoPerson = str0utput;
        return View("Index");
    }
    }
}