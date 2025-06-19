using Microsoft.AspNetCore.Mvc;
using ReportesMVC.Models;

namespace ReportesMVC.Controllers
{
    //Controlador para manejar el inicio de sesión
    public class LoginController : Controller
    {
        private readonly BDReportesContext _context;
        public LoginController (BDReportesContext context)
        {
            _context = context;
        }

        //vista de inicio de sesión
        public IActionResult Index()
        {
            return View();
        }

        //validar usuario
        [HttpPost]
        public IActionResult Index(Usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return View(usuario);
            }

            var usuarioValido = _context.Usuarios
                .FirstOrDefault(u => u.NombreUsuario == usuario.NombreUsuario && u.Contrasena == usuario.Contrasena);

            if (usuarioValido != null)
            {
                //Redireccionar a la página principal si el usuario es válido
                return RedirectToAction("Index", "Persona");
            }

            ViewBag.MensajeError = "Usuario o contraseña incorrectos.";
            return View(usuario);
        }
    }
}
