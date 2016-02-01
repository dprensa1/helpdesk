using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpDesk.Models.Repositorios
{
    public class CategoriaRepositorio : IRepositorio<Categoria>
    {
        HDContext _CategoriaContext = new HDContext();

        public IEnumerable<Categoria> List
        {
            get
            {
                return _CategoriaContext.Categorias;
            }
        }

        public void Add(Categoria entity)
        {
            _CategoriaContext.Categorias.Add(entity);
            _CategoriaContext.SaveChanges();
        }

        public void Delete(Categoria entity)
        {
            _CategoriaContext.Categorias.Remove(entity);
            _CategoriaContext.SaveChanges();
        }

        public Categoria FindById(int? Id)
        {
            var resultado = (from r in _CategoriaContext.Categorias where r.CategoriaId == Id select r).FirstOrDefault();

            return resultado;
        }

        public void Update(Categoria entity)
        {
            _CategoriaContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _CategoriaContext.SaveChanges();
        }
    }
}