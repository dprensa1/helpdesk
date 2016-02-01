using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpDesk.Models.Repositorios
{
    public class DepartamentoRepositorio : IRepositorio<Departamento>
    {
        HDContext _DepartamentoContext = new HDContext();

        public IEnumerable<Departamento> List
        {
            get
            {
                return _DepartamentoContext.Departamentos;
            }
        }

        public void Add(Departamento entity)
        {
            _DepartamentoContext.Departamentos.Add(entity);
            _DepartamentoContext.SaveChanges();
        }

        public void Delete(Departamento entity)
        {
            _DepartamentoContext.Departamentos.Remove(entity);
            _DepartamentoContext.SaveChanges();
        }

        public Departamento FindById(int Id)
        {
            var resultado = (from r in _DepartamentoContext.Departamentos where r.DepartamentoId == Id select r).FirstOrDefault();

            return resultado;
        }

        public void Update(Departamento entity)
        {
            _DepartamentoContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _DepartamentoContext.SaveChanges();
        }
    }
}