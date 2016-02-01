using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpDesk.Models.Repositorios
{
    public class ClienteRepositorio
    {
        HDContext _ClienteContext = new HDContext();

        public IEnumerable<Cliente> List
        {
            get
            {
                return _ClienteContext.Clientes;
            }
        }

        public void Add(Cliente entity)
        {
            _ClienteContext.Clientes.Add(entity);
            _ClienteContext.SaveChanges();
        }

        public void Delete(Cliente entity)
        {
            _ClienteContext.Clientes.Remove(entity);
            _ClienteContext.SaveChanges();
        }

        public Cliente FindById(int? Id)
        {
            var resultado = (from r in _ClienteContext.Clientes where r.ClienteId == Id select r).FirstOrDefault();

            return resultado;
        }

        public void Update(Cliente entity)
        {
            _ClienteContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _ClienteContext.SaveChanges();
        }
    }
}