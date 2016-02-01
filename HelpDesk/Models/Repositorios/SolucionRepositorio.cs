using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpDesk.Models.Repositorios
{
    public class SolucionRepositorio : IRepositorio<Solucion>
    {
        HDContext _SolucionContext;

        public IEnumerable<Solucion> List
        {
            get
            {
                return _SolucionContext.Soluciones;
            }
        }

        public void Add(Solucion entity)
        {
            _SolucionContext.Soluciones.Add(entity);
            _SolucionContext.SaveChanges();
        }

        public void Delete(Solucion entity)
        {
            _SolucionContext.Soluciones.Remove(entity);
            _SolucionContext.SaveChanges();
        }

        public Solucion FindById(int? Id)
        {
            var resultado = (from r in _SolucionContext.Soluciones where r.SolucionId == Id select r).FirstOrDefault();

            return resultado;
        }

        public void Update(Solucion entity)
        {
            _SolucionContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _SolucionContext.SaveChanges();
        }
    }
}