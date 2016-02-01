using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpDesk.Models.Repositorios
{
    public class TecnicoRepositorio : IRepositorio<Tecnico>
    {
        HDContext _TecnicoContext = new HDContext();

        public IEnumerable<Tecnico> List
        {
            get
            {
                return _TecnicoContext.Tecnicos;
            }
        }

        public void Add(Tecnico entity)
        {
            _TecnicoContext.Tecnicos.Add(entity);
            _TecnicoContext.SaveChanges();
        }

        public void Delete(Tecnico entity)
        {
            _TecnicoContext.Tecnicos.Remove(entity);
            _TecnicoContext.SaveChanges();
        }

        public Tecnico FindById(int? Id)
        {
            var resultado = (from r in _TecnicoContext.Tecnicos where r.TecnicoId == Id select r).FirstOrDefault();

            return resultado;
        }

        public void Update(Tecnico entity)
        {
            _TecnicoContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _TecnicoContext.SaveChanges();
        }
    }
}