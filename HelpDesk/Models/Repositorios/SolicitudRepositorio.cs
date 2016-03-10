using System.Collections.Generic;
using System.Linq;

namespace HelpDesk.Models.Repositorios
{
    public class SolicitudRepositorio : IRepositorio<Solicitud>
    {
        HDContext _SolicitudContext = new HDContext();

        public IEnumerable<Solicitud> List
        {
            get
            {
                return _SolicitudContext.Solicitudes;
            }
        }

        public void Add(Solicitud entity)
        {
            _SolicitudContext.Solicitudes.Add(entity);
            _SolicitudContext.SaveChanges();
        }

        public void Delete(Solicitud entity)
        {
            _SolicitudContext.Solicitudes.Remove(entity);
            _SolicitudContext.SaveChanges();
        }

        public Solicitud FindById(int Id)
        {
            var resultado = (from r in _SolicitudContext.Solicitudes where r.SolicitudId == Id select r).FirstOrDefault();

            return resultado;
        }

        public void Update(Solicitud entity)
        {
            _SolicitudContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            _SolicitudContext.SaveChanges();
        }
    }
}