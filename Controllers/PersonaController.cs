using Microsoft.AspNetCore.Mvc;
using ReportesMVC.Models;
using System.Linq;

namespace ReportesMVC.Controllers
{
    public class PersonaController : Controller
    {
        private readonly BDReportesContext _context;
        public PersonaController(BDReportesContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var personas = _context.Personas.Where( p => p.BHABILITADO == 1).ToList();

            if (personas == null)
                personas = new List<Persona>();

            return View(personas);
        }

        public IActionResult Editar(int id)
        {
            var persona = _context.Personas.Find(id);

            if (persona == null)
                return NotFound();

            return View(persona);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(Persona persona)
        {

            if (ModelState.IsValid)
            {
                _context.Personas.Update(persona);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(persona);
        }

        public IActionResult Eliminar (int id)
        {
            var persona = _context.Personas.Find(id);
            if (persona == null)
                return NotFound();

            return View(persona);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Eliminar (Persona persona)
        {
            var personaDb = _context.Personas.Find(persona.IIDPERSONA);

            if (personaDb == null)
                return NotFound();

            personaDb.BHABILITADO = 0;

            _context.Personas.Update(personaDb);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
