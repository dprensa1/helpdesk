using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpDesk.Models.Repositorios
{
    public class UsuarioRepositorio : IRepositorio<Usuario>
    {
        HDContext _UsuarioContext = new HDContext();

        public IEnumerable<Usuario> List
        {
            get
            {
                return _UsuarioContext.Usuarios;
            }
        }

        public void Add(Usuario entity)
        {
            _UsuarioContext.Usuarios.Add(entity);
            _UsuarioContext.SaveChanges();
        }

        public void Delete(Usuario entity)
        {
            _UsuarioContext.Usuarios.Remove(entity);
            _UsuarioContext.SaveChanges();
        }

        public Usuario FindById(int? Id)
        {
            var resultado = (from r in _UsuarioContext.Usuarios where r.UsuarioId == Id select r).FirstOrDefault();

            return resultado;
        }

        public void Update(Usuario entity)
        {
            _UsuarioContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _UsuarioContext.SaveChanges();
        }
    }
}