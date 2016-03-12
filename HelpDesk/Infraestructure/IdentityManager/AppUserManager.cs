using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using HelpDesk.Models;

namespace HelpDesk.Infraestructure.IdentityManager
{
    public class AppUserManager : UserManager<Usuario>
    {
        public AppUserManager(IUserStore<Usuario> store) : base(store)
        {
        }

        public static AppUserManager Create(IdentityFactoryOptions<AppUserManager> options, IOwinContext context)
        {
            HDContext db = context.Get<HDContext>();
            AppUserManager manager = new AppUserManager(new UserStore<Usuario>(db));

            manager.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = false,
                RequireDigit = false,
                RequireLowercase = false,
                RequireUppercase = true
            };
            return manager;
        }
    }
}