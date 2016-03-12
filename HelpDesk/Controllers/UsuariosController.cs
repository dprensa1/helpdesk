using HelpDesk.Models;
using System.Web.Mvc;

namespace HelpDesk.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        // POST: Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Usuario usuario, string returnUrl = "")
        {
            return View(usuario);
        }

        // GET: LogOut
        public ActionResult LogOut()
        {
            return View();
        }
    }
}