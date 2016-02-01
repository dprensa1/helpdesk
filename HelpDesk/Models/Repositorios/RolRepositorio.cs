using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpDesk.Models.Repositorios
{
    public class RolRepositorio
    {
        HDContext _RolContext;

        public IEnumerable<Rol> List
        {
            get
            {
                return _RolContext.Roles;
            }
        }

        public void Add(Rol entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Rol entity)
        {
            throw new NotImplementedException();
        }

        public Rol FindById(int? Id)
        {
            var resultado = (from r in _RolContext.Roles where r.RolId == Id select r).FirstOrDefault();

            return resultado;
        }

        public void Update(Rol entity)
        {
            throw new NotImplementedException();
        }
    }
}