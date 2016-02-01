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

        public Usuario FindById(int id)
        {
            var resultado = _UsuarioContext.Usuarios.Find(id);

            return resultado;
            //throw new NotImplementedException();
        }

        public Usuario FindByUserName(string _UserName)
        {
            var resultado =
                _UsuarioContext.Usuarios
                .FirstOrDefault(
                    u => u.UserName.Equals(_UserName)
                );

            return resultado;
            //throw new NotImplementedException();
        }

        public void Update(Usuario entity)
        {
            _UsuarioContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _UsuarioContext.SaveChanges();
        }

        public Usuario ValidateUser(string user, string pass)
        {
            //Trabajar con el hash para el pass
            var Usuario = _UsuarioContext.Usuarios
                .Where(
                    u => u.UserName == user && u.Clave == pass
                    ).FirstOrDefault();

            return Usuario;
        }
    }
}