using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpDesk.Models.Repositorios
{
    public class DocumentoRepositorio : IRepositorio<Documento>
    {
        HDContext _DocumentoContext = new HDContext();

        public IEnumerable<Documento> List
        {
            get
            {
                return _DocumentoContext.Documentos;
            }
        }

        public void Add(Documento entity)
        {
            _DocumentoContext.Documentos.Add(entity);
            _DocumentoContext.SaveChanges();
        }

        public void Delete(Documento entity)
        {
            _DocumentoContext.Documentos.Remove(entity);
            _DocumentoContext.SaveChanges();
        }

        public Documento FindById(int Id)
        {
            var resultado = (from r in _DocumentoContext.Documentos where r.DocumentoId == Id select r).FirstOrDefault();

            return resultado;
        }

        public void Update(Documento entity)
        {
            _DocumentoContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _DocumentoContext.SaveChanges();
        }
    }
}