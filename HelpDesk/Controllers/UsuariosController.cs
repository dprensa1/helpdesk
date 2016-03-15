using HelpDesk.Models;
using HelpDesk.ViewModels;
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
        public ActionResult Login(LoginViewModel usuario, string returnUrl = "")
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