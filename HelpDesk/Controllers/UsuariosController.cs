using HelpDesk.ViewModels;
using System.Web.Mvc;
using HelpDesk.Models.Repositorios;
using HelpDesk.Models;
using System.Web.Security;
using System.Linq;
using Newtonsoft.Json;
using System;
using System.Web;

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
        public ActionResult Login(LoginViewModel _usuario, string returnUrl = "")
        {
            UsuarioRepositorio UsuarioRepositorio = new UsuarioRepositorio();

            if (ModelState.IsValid)
            {
                var usuario = UsuarioRepositorio.ValidateUser(_usuario.User, _usuario.Clave);

                if (usuario != null)
                {
                    var roles = usuario.Roles.Select(r => r.Nombre).ToArray();

                    CustomPrincipalSerializeModel sM = new CustomPrincipalSerializeModel();
                    sM.UsuarioId = usuario.UsuarioId;
                    sM.Nombre = usuario.Nombre;
                    sM.Apellido = usuario.Apellido;
                    sM.Roles = roles;

                    string userData = JsonConvert.SerializeObject(sM);
                    FormsAuthenticationTicket authTicket = 
                        new FormsAuthenticationTicket(
                            1,
                            usuario.UserName,
                            DateTime.Now,
                            DateTime.Now.AddMinutes(15),
                            false, //pass here true, if you want to implement remember me functionality
                            userData);

                    string encTicket = FormsAuthentication.Encrypt(authTicket);
                    HttpCookie faCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
                    Response.Cookies.Add(faCookie);

                    if (roles.Contains("admin"))
                    {
                        return RedirectToAction("Index", "Inicio");
                    }
                    else if (roles.Contains("user"))
                    {
                        return RedirectToAction("Inicio", "Inicio");
                    }
                    else
                    {
                        return RedirectToAction("Login", "Usuario");
                    }
                }
                ModelState.AddModelError("", "Incorrect username and/or password");
            }

            return View(_usuario);
        }

        // GET: LogOut
        public ActionResult LogOut()
        {
            return View();
        }

    }
}
